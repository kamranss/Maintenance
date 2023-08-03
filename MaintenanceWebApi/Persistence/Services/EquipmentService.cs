using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
using Application.Repositories.EquipmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class EquipmentService:IEquipmentService
    {

        private readonly IEquipmentReadRepository? _equipmentReadRepository;
        private readonly IEquipmentWriteRepository? _equipmentWriteRepository;
        private readonly IMapper _mapper;
        public EquipmentService(IEquipmentReadRepository? equipmentReadRepository, IEquipmentWriteRepository? equipmentWriteRepository, IMapper mapper)
        {
            _equipmentReadRepository = equipmentReadRepository;
            _equipmentWriteRepository = equipmentWriteRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment)
        {

            if (equipment == null)
            {
                return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment object is null!" };
            }

            //if (equipment.EquipmentType != null)
            //{
            //    Enum.TryParse<EquipmentType>(equipment.EquipmentType, out var equipmentType));
            //}
            if (equipment.Image != null)
            {
                var newEquipment = _mapper.Map<Equipment>(equipment);
                var result =  await _equipmentWriteRepository.AddAsync(newEquipment);
                if (result)
                {
                    await _equipmentWriteRepository.SaveAsync();
                }
              

                // Map the 'newEquipment' back to 'EquipmentCreateDto' before returning it
                var mappedEquipment = _mapper.Map<EquipmentCreateDto>(newEquipment);

                return new ServiceResult<EquipmentCreateDto> { IsSuccess = true, Data = mappedEquipment };
            }
            else
            {
                return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment image is missing!" };
            }
        }

        //readonly IQRCodeService _qrCodeService;


        public EquipmentGetDto Deatil(int? id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public EquipmentGetDto FindEquipment(int? id)
        {
            throw new NotImplementedException();
        }

  
        public List<EquipmentGetDto> GetEquipment()
        {
            throw new NotImplementedException();
        }

        public Pagination<EquipmentGetDto> GetEquipments(int page, int take)
        {
            throw new NotImplementedException();
        }

        public EquipmentGetDto IsEquipmentExist(int? id)
        {
            throw new NotImplementedException();
        }

        public Equipment MapEquipemntDtoToEntity(EquipmentUpdateDto product)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> QrCodeToEquipmentAsync(string equipmentId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveEquipmentImage(IFormFile newImage, Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public Task StockUpdateToEquipmentAsync(string equipmentId, int stock)
        {
            throw new NotImplementedException();
        }

        Task<IServiceResult<EquipmentCreateDto>> IEquipmentService.CreateEquipment(EquipmentCreateDto product)
        {
            throw new NotImplementedException();
        }
    }
}
