using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.UsageHistory;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.UsageHistoryRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.EquipmentRepo;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class UsageHistoryService : IUsageHistoryService
    {
        private readonly IUsageHistoryReadRepository _readRepository;
        private readonly IUsageHistoryWriteRepository _writeRepository;
        private readonly IEquipmentReadRepository _equipmentReadRepository;
        private readonly IMapper _mapper;

        public UsageHistoryService(IUsageHistoryReadRepository readRepository, IUsageHistoryWriteRepository writeRepository, IEquipmentReadRepository equipmentReadRepository, IMapper mapper)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _equipmentReadRepository = equipmentReadRepository;
            _mapper = mapper;
        }

        public async Task<IServiceResult<UsageHistoryCreateDto>> CreateUsageHistoryAsync(UsageHistoryCreateDto usageHistoryCreate)
        {
            if (!usageHistoryCreate.EquipmentId.HasValue && usageHistoryCreate.EquipmentId <= 0)
            {
                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existEquipment = _equipmentReadRepository.GetAll().FirstOrDefault(d => d.Id == usageHistoryCreate.EquipmentId);
            if (existEquipment == null)
            {
                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }

            var newUsageHistory = _mapper.Map<UsageHistory>(usageHistoryCreate);

            var result = await _writeRepository.AddAsync(newUsageHistory);
            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();

                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = true, Data = usageHistoryCreate };

            }

            return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        }

        public async Task<IServiceResult<UsageHistoryEndDto>> EndUsageHistoryAsync(UsageHistoryEndDto? usageHistoryEnd)
        {
            if (!usageHistoryEnd.UsageHistoryId.HasValue == null && usageHistoryEnd.UsageHistoryId <= 0)
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existUsageStory = _readRepository.GetAll().FirstOrDefault(d => d.Id == usageHistoryEnd.UsageHistoryId);
            if (existUsageStory == null)
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "There is no Info with this Id in Db" };
            }

            existUsageStory.EndDate = usageHistoryEnd.EndDate;
            existUsageStory.TotalUsageValue = usageHistoryEnd.EndUsageHourValue - existUsageStory.StartUsageHourValue;

             _writeRepository.Update(existUsageStory);
            var endresult = await _writeRepository.SaveAsync();
            var updateEquipmentValue =  _equipmentReadRepository.GetAll().FirstOrDefault(e => e.Id == existUsageStory.EquipmentId);
            if (updateEquipmentValue==null)
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "SomethingWnetWrong" };
            }
            updateEquipmentValue.CurrentValue = usageHistoryEnd.EndUsageHourValue;
            return new ServiceResult<UsageHistoryEndDto> { IsSuccess = true, Data = usageHistoryEnd };
       

            //return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        }

        public async Task<IServiceResult<Pagination<UsageHistoryDto>>> FindEquipmentUsageHistoryAsync(int? equipmentId, int? page, int? pageSize)
        {
            if (!equipmentId.HasValue && equipmentId <= 0)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }

            if (page == null && pageSize == null)
            {
                var countt = _readRepository.GetAll().Where(uh => uh.IsDeleted == false && uh.IsActive == true && uh.EquipmentId == equipmentId).Count();
                int pageValuee = 1;
                int takeValuee = countt / 2;

                var usageHistory = _readRepository
               .GetAll()
               .Take(takeValuee)
               .Where(uh => uh.IsDeleted == false && uh.IsActive == true && uh.EquipmentId == equipmentId)
               .ToList();

                if (usageHistory == null)
                {
                    return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "There is no UsageHistory in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var usaageHistoryDto = _mapper.Map<List<UsageHistoryDto>>(usageHistory);
                var paginationUsageHistory = new Pagination<UsageHistoryDto>(usaageHistoryDto, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data = paginationUsageHistory };


            }


            if (!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            var count = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;

            var items = _readRepository
               .GetAll()
               .Skip(skipCount)
               .Take(takeValue)
               .Where(uh => uh.IsDeleted == false && uh.IsActive == true && uh.EquipmentId == equipmentId)
               .ToList();

            if (items == null)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "There is no UsageHistory in DB" };
            }
            var totalCount = count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
            var usageHistoryDto = _mapper.Map<List<UsageHistoryDto>>(items);
            var paginationUsageHistoryy = new Pagination<UsageHistoryDto>(usageHistoryDto, pageValue, pageCount, totalCount);
            return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data = paginationUsageHistoryy };



            //var history = _readRepository.GetAll().FirstOrDefault(d => d.EquipmentId == EquipmentId);
            //if (history==null)
            //{
            //    return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "No data found" };
            //}
            //var mappedHistory = _mapper.Map<List<UsageHistoryDto>>(history);

            //return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data=mappedHistory };

        }
    }
}
