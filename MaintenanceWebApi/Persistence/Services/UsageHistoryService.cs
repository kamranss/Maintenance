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

             _writeRepository.Update(existUsageStory);
            var endresult = await _writeRepository.SaveAsync();
            return new ServiceResult<UsageHistoryEndDto> { IsSuccess = true, Data = usageHistoryEnd };
       

            //return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        }


        Task<IServiceResult<Pagination<UsageHistoryDto>>> IUsageHistoryService.FindEquipmentUSageAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
