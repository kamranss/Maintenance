using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Parts;
using Application.DTOs.UsageHistory;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.MaintenanceSettingsRepo;
using Application.Repositories.UsageHistoryRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
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
        private readonly IEquipmentWriteRepository _equipmentWritwepository;
        private readonly IMSettingsReadRepository _settingsReadRepository;
        private readonly IMSettingsWriteRepository  _settingsWriteRepository;
        private readonly IMapper _mapper;

        public UsageHistoryService(IUsageHistoryReadRepository readRepository, IUsageHistoryWriteRepository writeRepository, IEquipmentReadRepository equipmentReadRepository, IMapper mapper, IMSettingsReadRepository settingsReadRepository, IMSettingsWriteRepository settingsWriteRepository, IEquipmentWriteRepository equipmentWritwepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _equipmentReadRepository = equipmentReadRepository;
            _mapper = mapper;
            _settingsReadRepository = settingsReadRepository;
            _settingsWriteRepository = settingsWriteRepository;
            _equipmentWritwepository = equipmentWritwepository;
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
            if (existEquipment.Status != Domain.Concrets.EquipmentStatus.ACTIVE && existEquipment.IsIdle!=true)
            {
                return new ServiceResult<UsageHistoryCreateDto> { IsSuccess = false, ErrorMessage = "Equipment cannot be used" };
            }

            var newUsageHistory = _mapper.Map<UsageHistory>(usageHistoryCreate);
            newUsageHistory.OperationNameValue = usageHistoryCreate.OperationName.Value.ToString();
             newUsageHistory.StartUsageHourValue = existEquipment.CurrentValue;
            newUsageHistory.Status = Domain.Concrets.UsageHistoryStatus.ONGOING;
            newUsageHistory.IsActive = true;
            newUsageHistory.IsDeleted = false;
            if (usageHistoryCreate.StartDate == null)
            {
                newUsageHistory.StartDate = DateTime.UtcNow;
            }
            //newUsageHistory.StartDate = usageHistoryCreate.StartDate;
            existEquipment.IsIdle = false;
            existEquipment.Status = EquipmentStatus.IN_USE;

            var result = await _writeRepository.AddAsync(newUsageHistory);

            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();
                var endEquResult = await _equipmentWritwepository.SaveAsync();

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
            if (existUsageStory.Status != Domain.Concrets.UsageHistoryStatus.ONGOING)
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "The History already Ended" };
            }

            existUsageStory.EndDate = usageHistoryEnd.EndDate ?? DateTime.UtcNow;



            DateTime startDate = existUsageStory.StartDate;
            DateTime endDate = existUsageStory.EndDate;

            TimeSpan duration = endDate - startDate;
            double durationInMinutes = duration.TotalMinutes;
            decimal durationDecimal = (decimal)durationInMinutes;

            existUsageStory.EndUsageHourValue = usageHistoryEnd.EndUsageHourValue;
            existUsageStory.Status = Domain.Concrets.UsageHistoryStatus.FINISHED;
            existUsageStory.TotalUsageTime = durationDecimal;
            existUsageStory.TotalUsageValue = usageHistoryEnd.EndUsageHourValue - existUsageStory.StartUsageHourValue;

            var existEqu = _equipmentReadRepository.GetAll().FirstOrDefault(d => d.Id == existUsageStory.EquipmentId);
            existEqu.CurrentValue = existUsageStory.EndUsageHourValue;
            existEqu.Status = EquipmentStatus.ACTIVE;
            existEqu.IsIdle = true;
            //existEqu.MpCompleted = true;
            _writeRepository.Update(existUsageStory);
            var endresult = await _writeRepository.SaveAsync();
            var updateEquipmentValue =  _equipmentReadRepository.GetAll().FirstOrDefault(e => e.Id == existUsageStory.EquipmentId);
            if (updateEquipmentValue==null)
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "SomethingWnetWrong" };
            }
            //updateEquipmentValue.CurrentValue = usageHistoryEnd.EndUsageHourValue;

            var existSettings = _settingsReadRepository.GetAll()
                .Include(s => s.MaintenancePlan)
                .Where(es => es.EquipmentId == existUsageStory.EquipmentId).ToList();
            if (existSettings.Count == 0) 
            {
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, Data = usageHistoryEnd };
            }

            foreach (var existSetting in existSettings)
            {
                existSetting.UpdatedValue = usageHistoryEnd.EndUsageHourValue;
                int check = 0;
                if ((existSetting.UpdatedValue - existSetting.StartValue) >= existSetting.SequenceValue)
                {
                    existSetting.IsMpCompleted = false;
                    existEqu.MpCompleted = false;
                    existSetting.StartValue = existEqu.CurrentValue;
                    //existSetting.MaintenancePlan.MPChecked = false;
                    check++;
                }

               var resultSet =  _settingsWriteRepository.Update(existSetting);
                if (!resultSet)
                {
                    return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "History not updated" };
                }
                if (check>0)
                {
                    var resultEqu = _equipmentWritwepository.Update(existEqu);
                    if (!resultEqu)
                    {
                        return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "Equipment not updated" };
                    }
                }
                
               
            }

            var endResultSet = await _settingsWriteRepository.SaveAsync();
            if (endResultSet >=1)
            {
               var endResultEqu = await _equipmentWritwepository.SaveAsync();
 
                return new ServiceResult<UsageHistoryEndDto> { IsSuccess = true, Data = usageHistoryEnd };
                //return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "Equipment not Saves" };
            }

            //_settingsWriteRepository.Update(existSettings);

            return new ServiceResult<UsageHistoryEndDto> { IsSuccess = false, ErrorMessage = "Equipment not Saves" };
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

        public async Task<IServiceResult<Pagination<UsageHistoryDto>>> UsageHistoriesAsync(int? page, int? pageSize)
        {

            if (page == null && pageSize == null)
            {
                var countt = _readRepository
                    .GetAll()
                    .Where(uh => uh.IsDeleted == false && uh.IsActive == true)
                    .Count();


                int pageValuee = 1;
                int takeValuee = countt / 2;

                var usageHistory = _readRepository
               .GetAll()
               .Include(u => u.Equipment) // Include the Equipment navigation property
               .OrderBy(u => u.Status != UsageHistoryStatus.ONGOING)
               .Take(takeValuee)
               .ToList();

                if (usageHistory == null)
                {
                    return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "There is no UsageHistory in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                //var usaageHistoryDto = _mapper.Map<List<UsageHistoryDto>>(usageHistory);

                var usageHistoryDtoo = usageHistory.Select(uh => new UsageHistoryDto
                {
                    Id = uh.Id,
                    OperationName = uh.OperationNameValue,
                    StartUsageHourValue = uh.StartUsageHourValue,
                    EndUsageHourValue = uh.EndUsageHourValue,
                    OperatorName = uh.OperatorName,
                    TotalUsageValue = uh.TotalUsageValue,
                    StartDate = uh.StartDate,
                    EndDate = uh.EndDate,
                    Status = uh.Status,
                    TotalTime = uh.TotalUsageTime,
                    EquipmentName = uh.Equipment.Name // Include Equipment Name in DTO
                }).ToList();
                var paginationUsageHistory = new Pagination<UsageHistoryDto>(usageHistoryDtoo, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data = paginationUsageHistory };


            }


            if (!page.HasValue || !pageSize.HasValue || page <= 0 || pageSize <= 0)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            var count = _readRepository.GetAll()/*.Where(d => d.IsDeleted == false && d.IsActive == true)*/.Count();
            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;

            var items = _readRepository
               .GetAll()
               .Include(u => u.Equipment)
               .OrderBy(u => u.Status != UsageHistoryStatus.ONGOING)
               .Skip(skipCount)
               .Take(takeValue)
               //.Where(uh => uh.IsDeleted == false && uh.IsActive == true)
               .ToList();

            if (items == null)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "There is no UsageHistory in DB" };
            }

            var usageHistoryDtooo = items.Select(uh => new UsageHistoryDto
            {
                Id = uh.Id,
                OperationName = uh.OperationNameValue,
                StartUsageHourValue = uh.StartUsageHourValue,
                EndUsageHourValue = uh.EndUsageHourValue,
                OperatorName = uh.OperatorName,
                TotalUsageValue = uh.TotalUsageValue,
                StartDate = uh.StartDate,
                EndDate = uh.EndDate,
                Status = uh.Status,
                TotalTime = uh.TotalUsageTime,
                EquipmentName = uh.Equipment.Name // Include Equipment Name in DTO
            }).ToList();

            var totalCount = count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);
            //var usageHistoryDto = _mapper.Map<List<UsageHistoryDto>>(items);

            var paginationUsageHistoryy = new Pagination<UsageHistoryDto>(usageHistoryDtooo, pageValue, pageCount, totalCount);
            return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data = paginationUsageHistoryy };




        }
    }
}
