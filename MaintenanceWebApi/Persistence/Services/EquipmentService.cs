using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
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
             
                        var newlyAddedEquipment = _equipmentReadRepository.GetWhere(d => d.Name == newEquipment.Name).ToList();
                        if (newlyAddedEquipment != null)
                        {
                            var mappedEquipment2 = _mapper.Map<EquipmentCreateDto>(newlyAddedEquipment);
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



        } // done

        //readonly IQRCodeService _qrCodeService;


        public EquipmentGetDto Deatil(int? id)
        {
            throw new NotImplementedException();
        }

      
        public async Task<IServiceResult<Pagination<EquipmentListDto>>> GetEquipmentsAsync(int? page, int? pagesize)
        {
          
            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0))
            {
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;

            List<EquipmentCachedDto> cachedEquipments;
            bool EquipmentsAlreadyExist = _memoryCach.TryGetValue("CachedEquipmentss", out cachedEquipments);
            if (!EquipmentsAlreadyExist)
            {
               var EquipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false);

                var items = EquipmentsFromDb
                 .Skip((pageValue - 1) * takeValue)
                 .Take(takeValue)
                 .Where(e => e.isDeleted == false)
                 .ToList();

                
                if (items == null)
                {
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
                }
                var totalCount = items.Count;
                var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

                var equipmentListDto = _mapper.Map<List<EquipmentListDto>>(items);
                var pagination = new Pagination<EquipmentListDto>(equipmentListDto, pageValue, pageCount, totalCount);

                EquipmentsFromDb.ToList();
                 var cachEntryOption = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromDays(10));
                _memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);


                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = pagination };
            }
            else
            {
                var items = cachedEquipments
                    .Skip((pageValue - 1) * takeValue)
                    .Take(takeValue)
                    .Where(e => e.IsDeleted == false)
                    .ToList();

                if (items.Count == 0)
                {
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no equipment in Db" };
                }

                var totalCount = items.Count;
                var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

                var equipmentListDto = _mapper.Map<List<EquipmentListDto>>(items);
                var pagination = new Pagination<EquipmentListDto>(equipmentListDto, pageValue, pageCount, totalCount);
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = pagination };

            }

           
        } // done

        public EquipmentGetDto IsEquipmentExist(int? id)
        {
            throw new NotImplementedException();
        }


        public Task<byte[]> QrCodeToEquipmentAsync(string equipmentId)
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

        public async Task<IServiceResult<EquipmentListDto>> FindEquipmentAsync(int? id)
        {
            if (!id.HasValue && id <= 0)
            {
                return new ServiceResult<EquipmentListDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            var existEquipment = _equipmentReadRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (existEquipment == null)
            {
                return new ServiceResult<EquipmentListDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }
            var equipmentListDto = _mapper.Map<EquipmentListDto>(existEquipment);

            return new ServiceResult<EquipmentListDto> { IsSuccess = true, Data = equipmentListDto };
        } // done

        public async Task<IServiceResult<EquipmentDto>> DeleteEquipmentAsync(int id)
        {
            if (id == null && id <= 0)
            {
                return new ServiceResult<EquipmentDto> { IsSuccess = false, ErrorMessage = "The id should not be null" };
            }

            var existEquipment = await _equipmentReadRepository.GetByIdAsync(id);

            if (existEquipment == null)
            {
                return new ServiceResult<EquipmentDto> { IsSuccess = false, ErrorMessage = "The Equipment not found" };
            }
            var result = _equipmentWriteRepository.Remove(existEquipment);
            if (result == true)
            {
                await _equipmentWriteRepository.SaveAsync();

                List<EquipmentCreateDto> cachedEquipments;
                bool EquipmentsAlreadyExist = _memoryCach.TryGetValue("CachedEquipmentss", out cachedEquipments);
                var EquipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false).ToList();
                var cachEntryOption = new MemoryCacheEntryOptions()
                       .SetSlidingExpiration(TimeSpan.FromDays(10));
                if (!EquipmentsAlreadyExist)
                {
                   
                    _memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);

                }
                _memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);

                var mappedEquipment = _mapper.Map<EquipmentDto>(existEquipment);
                return new ServiceResult<EquipmentDto> { IsSuccess = true, Data = mappedEquipment };
            }
            return new ServiceResult<EquipmentDto> { IsSuccess = false, ErrorMessage = "Something Went Wrong" };
        } // done

        public async Task<IServiceResult<EquipmentUpdateDto>> UpdateEquipemntAsync(EquipmentUpdateDto equipmentUpdateDto)
        {

            var existEquipment = _equipmentReadRepository.GetWhere(d => d.Id == equipmentUpdateDto.Id).FirstOrDefault();
            if (existEquipment == null)
            {
                return new ServiceResult<EquipmentUpdateDto> { IsSuccess = false, ErrorMessage = "Equipment not found" };
            }


            existEquipment.Name = equipmentUpdateDto.Name;
            existEquipment.Description = equipmentUpdateDto.Description;

            _equipmentWriteRepository.Update(existEquipment);
            _equipmentWriteRepository.SaveAsync();



            List<EquipmentCachedDto> cachedEquipments;
            bool EquipementsAlreadyExist = _memoryCach.TryGetValue("CachedDepartments", out cachedEquipments);
            if (!EquipementsAlreadyExist)
            {
                //var EquipmentsFromDb = _equipmentReadRepository.GetWhere(e => e.Id == newEquipment.Id);
                var equipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false).ToList();

                var cachEntryOption = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromDays(10));
                _memoryCach.Set("CachedEquipmentss", equipmentsFromDb, cachEntryOption);
            }
            else
            {
                var updatedCachedEquipments = cachedEquipments.Where(d => d.Id == equipmentUpdateDto.Id).FirstOrDefault();
                updatedCachedEquipments.Name = equipmentUpdateDto.Name;
                updatedCachedEquipments.Description = equipmentUpdateDto.Description;

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                         .SetSlidingExpiration(TimeSpan.FromDays(10));
                _memoryCach.Set("CachedEquipmentss", cachedEquipments, cacheEntryOptions);
            }

            return new ServiceResult<EquipmentUpdateDto> { IsSuccess = true, Data = equipmentUpdateDto };
        } // done



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
