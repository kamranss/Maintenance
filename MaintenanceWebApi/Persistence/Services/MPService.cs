﻿using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.MpRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class MPService : IMPService
    {

        private readonly IMpReadRepository _readRepository;
        private readonly IMpWriteRepository _writeRepository;
        private readonly IMapper _mapper;
        private IMemoryCache _memoryCach;

        public MPService(IMpReadRepository readRepository, IMpWriteRepository writeRepository, IMapper mapper, IMemoryCache memoryCach)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
        }

        public async Task<IServiceResult<MaintenancePlanCreateDto>> CreateMPAsync(MaintenancePlanCreateDto service)
        {
            var newService = _mapper.Map<MaintenancePlan>(service);
            newService.IsActive = true;
            newService.IsDeleted = true;

            var result = await _writeRepository.AddAsync(newService);
            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();

                if (endresult > 0)
                {
                    return new ServiceResult<MaintenancePlanCreateDto> { IsSuccess = true, Data = service };
                }
                return new ServiceResult<MaintenancePlanCreateDto> { IsSuccess = false, ErrorMessage = "Service could not be saved." };
            }

            return new ServiceResult<MaintenancePlanCreateDto> { IsSuccess = false, ErrorMessage = "Service could not be added." };
        } // done

        public async Task<IServiceResult<MaintenancePlanDto>> DeleteMPAsync(int id)
        {
            if (id == null && id <= 0)
            {
                return new ServiceResult<MaintenancePlanDto> { IsSuccess = false, ErrorMessage = "The id should not be null" };
            }

            var existMP = await _readRepository.GetByIdAsync(id);

            if (existMP == null)
            {
                return new ServiceResult<MaintenancePlanDto> { IsSuccess = false, ErrorMessage = "The MP not found" };
            }
            var result = _writeRepository.Remove(existMP);
            if (result == true)
            {
                await _writeRepository.SaveAsync();
                var mappedToDtoMP = _mapper.Map<MaintenancePlanDto>(existMP);
                return new ServiceResult<MaintenancePlanDto> { IsSuccess = true, Data = mappedToDtoMP };
            }
            return new ServiceResult<MaintenancePlanDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        } // done

        public async Task<IServiceResult<MaintenancePlanDto>> FindMPAsync(int? id)
        {
            if (!id.HasValue && id <= 0)
            {
                return new ServiceResult<MaintenancePlanDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existMP = _readRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (existMP == null)
            {
                return new ServiceResult<MaintenancePlanDto> { IsSuccess = false, ErrorMessage = "There is no Mp with this Id" };
            }
            var MaintenancePlanDto = _mapper.Map<MaintenancePlanDto>(existMP);

            return new ServiceResult<MaintenancePlanDto> { IsSuccess = true, Data = MaintenancePlanDto };
        } // done

        public async Task<IServiceResult<Pagination<MaintenancePlanDto>>> GetMPsAsync(int? page, int? pagesize)
        {
            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0))
            {
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;

           
            var MpsFromDb = _readRepository.GetAll(tracking: false);

            var items = MpsFromDb
             .Skip((pageValue - 1) * takeValue)
             .Take(takeValue)
             .Where(e => e.IsDeleted == false)
             .ToList();


            if (items == null)
            {
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "There is no MP in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var MpListDto = _mapper.Map<List<MaintenancePlanDto>>(items);
            var pagination = new Pagination<MaintenancePlanDto>(MpListDto, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = true, Data = pagination };

        } // done

        public async Task<IServiceResult<MaintenancePlanUpdateDto>> UpdateMPAsync(MaintenancePlanUpdateDto maintenancePlanUpdateDto)
        {
            var existMP = _readRepository.GetWhere(d => d.Id == maintenancePlanUpdateDto.Id).FirstOrDefault();
            if (existMP == null)
            {
                return new ServiceResult<MaintenancePlanUpdateDto> { IsSuccess = false, ErrorMessage = "MP not found" };
            }

            var checkMpName = _readRepository.GetWhere(d => d.Name == maintenancePlanUpdateDto.Name).Any();
            if (_readRepository.GetWhere(d => d.Name.ToLower() == maintenancePlanUpdateDto.Name.ToLower() && d.Id != maintenancePlanUpdateDto.Id).Any())
            {
                return new ServiceResult<MaintenancePlanUpdateDto> { IsSuccess = false, ErrorMessage = "Same Mp already exist you should pick another Name" };
            }

            if (!Enum.IsDefined(typeof(Metrictype), maintenancePlanUpdateDto.MetricType))
            {
                return new ServiceResult<MaintenancePlanUpdateDto> { IsSuccess = false, ErrorMessage = "Invalid MetricType value" };
            }

            existMP.Name = maintenancePlanUpdateDto.Name;
            existMP.Description = maintenancePlanUpdateDto.Description;
            existMP.Code = maintenancePlanUpdateDto.Code;
            existMP.MetricType = maintenancePlanUpdateDto.MetricType;

            _writeRepository.Update(existMP);
            _writeRepository.SaveAsync();

            return new ServiceResult<MaintenancePlanUpdateDto> { IsSuccess = true, Data = maintenancePlanUpdateDto };
        } // done

    
    }
}
