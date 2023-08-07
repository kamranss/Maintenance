using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Equipment;
using Application.Exceptions.EquipmentException;
using Application.Helpers.FileExten;
using Application.Repositories.EquipmentRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
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
        private IMemoryCache _memoryCach;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EquipmentService(IEquipmentReadRepository? equipmentReadRepository, IEquipmentWriteRepository? equipmentWriteRepository, IMapper mapper, IMemoryCache memoryCach, IWebHostEnvironment webHostEnvironment)
        {
            _equipmentReadRepository = equipmentReadRepository;
            _equipmentWriteRepository = equipmentWriteRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment)
        {
            if (!equipment.Image.CheckFileType())
            {
                return new ServiceResult<EquipmentCreateDto>
                {
                    IsSuccess = false,
                    ErrorMessage = "File Type is not correct"
                };
            }
            string imageUrl = equipment.Image.SaveFile(_webHostEnvironment, "images");

            var newEquipment = _mapper.Map<Equipment>(equipment);
            newEquipment.IsActive = true;
            newEquipment.IsDeleted = true;
            imageUrl = imageUrl + Guid.NewGuid();
            newEquipment.ImagUrl = imageUrl;
            if (!equipment.Image.CheckFileLenght(3000))
            {
                return new ServiceResult<EquipmentCreateDto>
                {
                    IsSuccess = false,
                    ErrorMessage = "File Size is bigger"
                };
            }


            var result = await _equipmentWriteRepository.AddAsync(newEquipment);
            if (result)
            {
                var endresult = await _equipmentWriteRepository.SaveAsync();

                if (endresult > 0)
                {
                    var mappedEquipment = _mapper.Map<EquipmentCreateDto>(newEquipment);

                    List<EquipmentCreateDto> cachedEquipments;
                    bool EquipmentsAlreadyExist = _memoryCach.TryGetValue("CachedEquipmentss", out cachedEquipments);
                    if (!EquipmentsAlreadyExist)
                    {
                        //var EquipmentsFromDb = _equipmentReadRepository.GetWhere(e => e.Id == newEquipment.Id);
                        var EquipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false).ToList();


                        var cachEntryOption = new MemoryCacheEntryOptions()
                            .SetSlidingExpiration(TimeSpan.FromDays(10));
                        _memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);
                    }
                    else
                    {

                        var equipments = cachedEquipments;

                        var equipmentsFromDb = _equipmentReadRepository.GetByIdAsync(newEquipment.Id);
                        if (equipmentsFromDb != null)
                        {
                            var mappedEquipment2 = _mapper.Map<EquipmentCreateDto>(equipmentsFromDb);
                            equipments.Add(mappedEquipment2);

                            // Update the cache with the updated products list
                            var cacheEntryOptions = new MemoryCacheEntryOptions()
                                .SetSlidingExpiration(TimeSpan.FromDays(10));
                            _memoryCach.Set("CachedEquipmentss", equipments, cacheEntryOptions);
                        }
                    }

                    return new ServiceResult<EquipmentCreateDto> { IsSuccess = true, Data = mappedEquipment };
                }
                return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be saved." };
            }

            return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be added." };



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

        public async Task<IServiceResult<Pagination<EquipmentListDto>>> GetEquipmentsAsync(int page, int take)
        {
          
            if (!(page>0 && take>0))
            {
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }

            var items = _equipmentReadRepository
               .GetAll()
               .Skip((page - 1) * take)
               .Take(take)
               .ToList();
            if (items == null)
            {
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / take);
            var equipmentListDto = _mapper.Map<List<EquipmentListDto>>(items);
            var pagination = new Pagination<EquipmentListDto>(equipmentListDto, page, pageCount, totalCount);
            return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = pagination };
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

 














        //public async Task<ServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment)
        //{
        //    try
        //    {

            //        //EquipmentCreateException.ValidateEquipmentProperties(equipment);
            //        var newEquipment = _mapper.Map<Equipment>(equipment);
            //        newEquipment.IsActive = true;
            //        newEquipment.IsDeleted = true;

            //        var result = await _equipmentWriteRepository.AddAsync(newEquipment);
            //        if (result)
            //        {
            //            var endresult = await _equipmentWriteRepository.SaveAsync();

            //            if (endresult > 0)
            //            {
            //                var mappedEquipment = _mapper.Map<EquipmentCreateDto>(newEquipment);

            //                List<EquipmentCreateDto> cachedEquipments;
            //                bool EquipmentsAlreadyExist = _memoryCach.TryGetValue("CachedEquipmentss", out cachedEquipments);
            //                if (!EquipmentsAlreadyExist)
            //                {
            //                    //var EquipmentsFromDb = _equipmentReadRepository.GetWhere(e => e.Id == newEquipment.Id);
            //                    var EquipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false).ToList();


            //                    var cachEntryOption = new MemoryCacheEntryOptions()
            //                        .SetSlidingExpiration(TimeSpan.FromDays(10));
            //                    _memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);
            //                }
            //                else
            //                {

            //                    var equipments = cachedEquipments;

            //                    var equipmentsFromDb = _equipmentReadRepository.GetByIdAsync(newEquipment.Id);
            //                    if (equipmentsFromDb != null)
            //                    {
            //                        var mappedEquipment2 = _mapper.Map<EquipmentCreateDto>(equipmentsFromDb);
            //                        equipments.Add(mappedEquipment2);

            //                        // Update the cache with the updated products list
            //                        var cacheEntryOptions = new MemoryCacheEntryOptions()
            //                            .SetSlidingExpiration(TimeSpan.FromDays(10));
            //                        _memoryCach.Set("CachedEquipmentss", equipments, cacheEntryOptions);
            //                    }
            //                }

            //                return new ServiceResult<EquipmentCreateDto> { IsSuccess = true, Data = mappedEquipment };
            //            }
            //            return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be saved." };
            //        }

            //        return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be added." };
            //    }
            //    catch (EquipmentCreateException)
            //    {
            //        return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Somthing Went Wrong" };
            //        //return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = ValidateEquipmentProperties.Message };
            //    }



            //}
    }
}
