using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.Repositories.EquipmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
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

        public void CreateEquipment(EquipmentCreateDto equipment)
        {
            try
            {
                if (equipment == null)
                {
                    return
                }
            }
            catch (Exception)
            {

                throw;
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
    }
}
