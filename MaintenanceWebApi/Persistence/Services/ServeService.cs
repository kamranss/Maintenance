using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Application.Repositories.MpRepo;
using Application.Repositories.ServiceHistoryRepo;
using Application.Repositories.ServiceRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class ServeService : IServeServices
    {
        private readonly IServiceReadRepository _readRepository;
        private readonly IServiceWriteRepository _writeRepository;
        private readonly IMpReadRepository _mpReadRepository;
        private readonly IServiceHistoryWriteRepository _serviceHistoryWriteRepository;
        private readonly IMapper _mapper;

        public ServeService(IServiceReadRepository readRepository, IServiceWriteRepository writeRepository, IMapper mapper, IServiceHistoryWriteRepository serviceHistoryWriteRepository)
        {
            this._readRepository = readRepository;
            this._writeRepository = writeRepository;
            _mapper = mapper;
            _serviceHistoryWriteRepository = serviceHistoryWriteRepository;
        }

        public async Task<IServiceResult<ServiceCreateDto>> CreateServiceAsync(ServiceCreateDto service)
        {
            if (service ==null)
            {
                return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "data missing" };
            }

            if (service.MaintenancePlanId == null || service.MaintenancePlanId<= 0)
            {
                return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "MP id is wrong" };
            }
            var existMp = _mpReadRepository.GetWhere(mp => mp.Id == service.MaintenancePlanId);
            if (existMp == null)
            {
                return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "Invalid Mp type value" };
            }
            if (!Enum.IsDefined(typeof(ServiceType), service.ServiceType))
            {
                return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "Invalid ServiceType value" };
            }
            var newService = _mapper.Map<Service>(service);
            newService.IsActive = true;
            newService.IsDeleted = true;

            var result = await _writeRepository.AddAsync(newService);
            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();

                if (endresult > 0)
                {
                    return new ServiceResult<ServiceCreateDto> { IsSuccess = true, Data = service };
                }
                return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "Service could not be saved." };
            }

            return new ServiceResult<ServiceCreateDto> { IsSuccess = false, ErrorMessage = "Service could not be added." };
        } // done

        public async Task<IServiceResult<ServiceDto>> DeleteServiceAsync(int id)
        {
            if (id == null && id <= 0)
            {
                return new ServiceResult<ServiceDto> { IsSuccess = false, ErrorMessage = "The id should not be null" };
            }

            var existService = await _readRepository.GetByIdAsync(id);

            if (existService == null)
            {
                return new ServiceResult<ServiceDto> { IsSuccess = false, ErrorMessage = "The Service not found" };
            }
            var result = _writeRepository.Remove(existService);
            if (result == true)
            {
                await _writeRepository.SaveAsync();
                var mappedToDtoService = _mapper.Map<ServiceDto>(existService);
                return new ServiceResult<ServiceDto> { IsSuccess = true, Data = mappedToDtoService };
            }
            return new ServiceResult<ServiceDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        } // done

        public async Task<IServiceResult<ServiceDto>> FindServiceAsync(int? id)
        {
            if (!id.HasValue && id <= 0)
            {
                return new ServiceResult<ServiceDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existService = _readRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (existService == null)
            {
                return new ServiceResult<ServiceDto> { IsSuccess = false, ErrorMessage = "There is no Service with this Id" };
            }
            var serviceDTO = _mapper.Map<ServiceDto>(existService);

            return new ServiceResult<ServiceDto> { IsSuccess = true, Data =serviceDTO };
        }

        public Task<IServiceResult<Pagination<ServiceDto>>> GetServicesAsync(int? page, int? take)
        {
            throw new NotImplementedException();
        }

        public async Task<IServiceResult<ServiceHistoryDto>> IsServiceCompleted(ServiceHistoryDto serviceHistoryDto) // createServiceHistory
        {
            var existService = _readRepository.GetAll().FirstOrDefault(s => s.Id == serviceHistoryDto.ServiceId);
            if (existService == null) return new ServiceResult<ServiceHistoryDto> { IsSuccess = false, ErrorMessage = "Service not found" };
            var serviceHistoryDTO = _mapper.Map<ServiceHistory>(existService);

            var result = await _serviceHistoryWriteRepository.AddAsync(serviceHistoryDTO);

            if (result)
            {
                var endresult = await _serviceHistoryWriteRepository.SaveAsync();

                if (endresult > 0)
                {
                    return new ServiceResult<ServiceHistoryDto> { IsSuccess = true, Data = serviceHistoryDto };
                }
                return new ServiceResult<ServiceHistoryDto> { IsSuccess = false, ErrorMessage = "Service could not be saved." };
            }
         

            return new ServiceResult<ServiceHistoryDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };


        }

        public async Task<IServiceResult<ServiceUpdateDto>> UpdateServiceAsync(ServiceUpdateDto serviceUpdateDto)
        {
            var existService = _readRepository.GetWhere(d => d.Id == serviceUpdateDto.Id).FirstOrDefault();
            if (existService == null)
            {
                return new ServiceResult<ServiceUpdateDto> { IsSuccess = false, ErrorMessage = "Serice not found" };
            }

         

            if (!Enum.IsDefined(typeof(ServiceType), serviceUpdateDto.ServiceType))
            {
                return new ServiceResult<ServiceUpdateDto> { IsSuccess = false, ErrorMessage = "Invalid ServiceType value" };
            }

            existService.Name = serviceUpdateDto.Name;
            existService.ServiceDescription = serviceUpdateDto.ServiceDescription;
            existService.ServiceType = serviceUpdateDto.ServiceType;
            _writeRepository.Update(existService);
            _writeRepository.SaveAsync();

            return new ServiceResult<ServiceUpdateDto> { IsSuccess = true, Data = serviceUpdateDto };
        } // done

     
    }
}
