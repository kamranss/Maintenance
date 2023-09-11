﻿using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Manufacture;
using Application.DTOs.Parts;
using Application.DTOs.Service;
using Application.DTOs.UsageHistory;
using Application.Exceptions.EquipmentException;
using Application.Helpers.FileExten;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.EquipmentMpRepo;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.ManufactureRepo;
using Application.Repositories.ModelRepo;
using Application.Repositories.MpRepo;
using Application.Repositories.OperationSiteRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistence.Services
{
    public class EquipmentService:IEquipmentService
    {

        private readonly IEquipmentReadRepository? _equipmentReadRepository;
        private readonly IEquipmentWriteRepository? _equipmentWriteRepository;
        private readonly IMapper _mapper;
        private IMemoryCache _memoryCach;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMpReadRepository _readRepository;
        //private readonly IModelService _modelService;
        //private readonly IManufactureService _manufactureService;
        //private readonly IDepartmentService _departmentService;
        //private readonly IOperationSiteService _operationSiteService;
        private readonly IModelReadRepository _modelReadRepository;
        private readonly IManufactureReadRepository _manufactureReadRepository;
        private readonly IDepartmentReadRepository _departmentReadRepository;
        private readonly IReadOperationSiteRepository _readOperationSiteRepository;
        private readonly IEquipmentMpReadRepository _equipmentMpReadRepository;
        private readonly IEquipmentMpWriteRepository _equipmentMpWriteRepository;

        public EquipmentService(IEquipmentReadRepository? equipmentReadRepository, IEquipmentWriteRepository? equipmentWriteRepository, IMapper mapper, IMemoryCache memoryCach, IWebHostEnvironment webHostEnvironment, IMpReadRepository readRepository, IModelReadRepository modelReadRepository, IManufactureReadRepository manufactureReadRepository, IDepartmentReadRepository departmentReadRepository, IReadOperationSiteRepository readOperationSiteRepository, IEquipmentMpReadRepository equipmentMpReadRepository, IEquipmentMpWriteRepository equipmentMpWriteRepository)
        {
            _equipmentReadRepository = equipmentReadRepository;
            _equipmentWriteRepository = equipmentWriteRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
            _webHostEnvironment = webHostEnvironment;
            _readRepository = readRepository;
            _modelReadRepository = modelReadRepository;
            _manufactureReadRepository = manufactureReadRepository;
            _departmentReadRepository = departmentReadRepository;
            _readOperationSiteRepository = readOperationSiteRepository;
            _equipmentMpReadRepository = equipmentMpReadRepository;
            _equipmentMpWriteRepository = equipmentMpWriteRepository;
        }

        public async Task<IServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment)
        {
            string imageUrl = "";
            if (equipment.Image != null)
            {
                //return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Image ismissing" };

                if (!equipment.Image.CheckFileType())
                {
                    return new ServiceResult<EquipmentCreateDto>
                    {
                        IsSuccess = false,
                        ErrorMessage = "File Type is not correct"
                    };
                }
                if (!equipment.Image.CheckFileLenght(9000000))
                {
                    return new ServiceResult<EquipmentCreateDto>
                    {
                        IsSuccess = false,
                        ErrorMessage = "File Size is bigger"
                    };
                }
                imageUrl = equipment.Image.SaveFile(_webHostEnvironment, "images");
            }
           

            if (equipment.UsageLocation != null)
            {
                if (!Enum.IsDefined(typeof(Location), equipment.UsageLocation))
                {
                    return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Invalid UsageLocation value" };
                }
            }

          


            var newEquipment = _mapper.Map<Equipment>(equipment);
            if (equipment.CurrentValue == null)
            {
                newEquipment.CurrentValue = 0;
            }
            newEquipment.IsActive = true;
            newEquipment.IsDeleted = true;
            var imageurl = imageUrl;
            newEquipment.ImagUrl = imageurl;
            newEquipment.Status = EquipmentStatus.ACTIVE;
            newEquipment.usageLocation = equipment.UsageLocation;
            newEquipment.MpCompleted = true;
            newEquipment.IsIdle = true;




            var result = await _equipmentWriteRepository.AddAsync(newEquipment);
            if (result)
            {
                var endresult = await _equipmentWriteRepository.SaveAsync();

                if (endresult > 0)
                {
                    return new ServiceResult<EquipmentCreateDto> { IsSuccess = true, Data = equipment };
                   
                  
                }
                return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be saved." };
            }

            return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Equipment could not be added." };



        } // should be modified

        //readonly IQRCodeService _qrCodeService;


        public EquipmentGetDto Deatil(int? id)
        {
            throw new NotImplementedException();
        } // will not use

      
        public async Task<IServiceResult<Pagination<EquipmentListDto>>> GetEquipmentsAsync(int? page, int? pagesize)
        {

            if (page == null && pagesize == null)
            {
                var countt = _equipmentReadRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt;

                var equipments = _equipmentReadRepository
               .GetAll()
               .Take(takeValuee)
               .Where(d => d.IsDeleted == false && d.IsActive == true)
               .Select(e => new EquipmentListDto
               {
                   Id = e.Id,
                   Status = e.Status,
                   Name = e.Name,
                   Description = e.Description,
                   LastMaintenace = e.LastMaintenaceDate,
                   CurrentValue = e.CurrentValue,
                   //Model = e.ModelId.HasValue ? e.Model.Name : null,
                   OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
                   //Department = e.DepartmentId.HasValue ? e.Department.Name : null,
                   //Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
                   Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
                   MpTime = e.MpCompleted
                   //ModelId = e.Model.Id,
                   //OperationSiteid = e.OperationSite.Id,
                   //DepartmentId = e.Department.Id,
                   //ManufactureId = e.Manufacture.Id,
                   //EquipmentTypeId = e.EquipmentType.Id,                  
               })
               .ToList();

                if (equipments == null)
                { 
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var equipmentListDtoo = _mapper.Map<List<EquipmentListDto>>(equipments);

               
                var paginationEquipemnts = new Pagination<EquipmentListDto>(equipmentListDtoo, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = paginationEquipemnts };


            }


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
                     .Where(e => e.IsDeleted == false || e.IsDeleted == null)
                       .Select(e => new EquipmentListDto
                       {
                           Id = e.Id,
                           Status = e.Status,
                           Name = e.Name,
                           Description = e.Description,
                           LastMaintenace = e.LastMaintenaceDate,
                           CurrentValue = e.CurrentValue,
                           //Model = e.ModelId.HasValue ? e.Model.Name : null,
                           OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
                           //Department = e.DepartmentId.HasValue ? e.Department.Name : null,
                           //Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
                           Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
                           MpTime = e.MpCompleted
                       })
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
                // var cachEntryOption = new MemoryCacheEntryOptions()
                //    .SetSlidingExpiration(TimeSpan.FromSeconds(5));
                //_memoryCach.Set("CachedEquipmentss", EquipmentsFromDb, cachEntryOption);


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
        } // will not use


        public Task<byte[]> QrCodeToEquipmentAsync(string equipmentId)
        {
            throw new NotImplementedException();
        } // will no use

        public void SaveEquipmentImage(IFormFile newImage, Equipment equipment)
        {
            throw new NotImplementedException();
        } // will not use

        public Task StockUpdateToEquipmentAsync(string equipmentId, int stock)
        {
            throw new NotImplementedException();
        } // will not use

        public async Task<IServiceResult<EquipmentDetailDto>> FindEquipmentAsync(int? id)
        {
            if (id == null)
            {
                return new ServiceResult<EquipmentDetailDto> { IsSuccess = false, ErrorMessage = "Should not be null" };
            }
            if (!id.HasValue && id <= 0)
            {
                return new ServiceResult<EquipmentDetailDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            //var existEquipment = _equipmentReadRepository.GetAll().FirstOrDefault(d => d.Id == id);
            //var equipment = _equipmentReadRepository
            //  .GetAll()
            //  .Where(e => e.Id == id)
            //  .Include(e => e.MaintenancePlan)
            //  .Include(e=>e.UsageHistories)
            //  .Include(e => e.Part)
            //  .Select(e => new EquipmentDetailDto
            //  {
            //      Id = e.Id,
            //      Status = e.Status,
            //      Name = e.Name,
            //      Description = e.Description,
            //      LastMaintenace = e.LastMaintenaceDate,
            //      CurrentValue = e.CurrentValue,
            //      Model = e.ModelId.HasValue ? e.Model.Name : null,
            //      OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
            //      Department = e.DepartmentId.HasValue ? e.Department.Name : null,
            //      Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
            //      Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
            //      MpTime = e.MpCompleted,
            //      UsageHistoryList = _mapper.Map<List<UsageHistoryDto>>(e.UsageHistories),
            //      MpList = _mapper.Map<List<MaintenancePlanDto>>(e.MaintenancePlan),
            //      PartList = _mapper.Map<List<PartDto>>(e.Part)


            //  })
            //  .ToList();
            //if (equipment == null)
            //{
            //    return new ServiceResult<EquipmentDetailDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            //}
            //var equipmentListDto = _mapper.Map<EquipmentDetailDto>(equipment);

            var equipment =  _equipmentReadRepository
                .GetAll()
                .Where(e => e.Id == id)
                .Include(e => e.Department)
                .Include(e => e.Manufacture)
                .Include(e => e.OperationSite)
                .Include(e => e.Model)
                .Include(e => e.EquipmentType)
                .Include(e => e.MaintenancePlan)
                .Include(e => e.UsageHistories)
                .Include(e => e.Part)
                .FirstOrDefault();

            Console.WriteLine(equipment);

            if (equipment == null)
            {
                return new ServiceResult<EquipmentDetailDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }

            EquipmentDetailDto equipmentDetailDto = new EquipmentDetailDto();

            //EquipmentDetailDto equipmentDetailDto = new EquipmentDetailDto
            //{

            //};
            equipmentDetailDto.Id = equipment.Id;
            equipmentDetailDto.Status = equipment.Status;
            equipmentDetailDto.Name = equipment.Name;
            equipmentDetailDto.Description = equipment.Description;
            equipmentDetailDto.LastMaintenace = equipment.LastMaintenaceDate;
            equipmentDetailDto.CurrentValue = equipment.CurrentValue;
            equipmentDetailDto.Model = equipment.ModelId.HasValue ? equipment.Model?.Name : null;
            equipmentDetailDto.OperationSite = equipment.OperationSiteid.HasValue ? equipment.OperationSite?.Name : null;
            equipmentDetailDto.Department = equipment.DepartmentId.HasValue ? equipment.Department?.Name : null;
            equipmentDetailDto.Manufacture = equipment.ManufactureId.HasValue ? equipment.Manufacture?.Name : null;
            equipmentDetailDto.Type = equipment.EquipmentTypeId.HasValue ? equipment.EquipmentType?.Name : null;
            equipmentDetailDto.MpTime = equipment.MpCompleted;
            equipmentDetailDto.UsageHistoryList = equipment.UsageHistories != null ? _mapper.Map<List<UsageHistoryDto>>(equipment.UsageHistories) : null;
            equipmentDetailDto.MpList = equipment.MaintenancePlan != null ? _mapper.Map<List<MaintenancePlanDto>>(equipment.MaintenancePlan) : null;
            equipmentDetailDto.PartList = equipment.Part != null ? _mapper.Map<List<PartDto>>(equipment.Part) : null;
            equipmentDetailDto.ImagUrl =  "/images/" + equipment.ImagUrl;
            

            return new ServiceResult<EquipmentDetailDto> { IsSuccess = true, Data = equipmentDetailDto };
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

        public async Task<IServiceResult<Pagination<UsageHistoryDto>>> GetUsageHistoryByEquipmentIdAsync(int? page, int? pagesize, int? id)
        {
            throw new NotImplementedException();
            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0 || id == null || id <= 0))
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;


            var EquFromDb = _equipmentReadRepository.GetWhere(e => e.Id == id);
            if (EquFromDb == null)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "Equipment not found" };
            }

            var items = EquFromDb
                .Include(e => e.UsageHistories) // Include related UsageHistories
                .Skip((pageValue - 1) * takeValue)
                .Take(takeValue)
                .ToList();

            if (items == null)
            {
                return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = false, ErrorMessage = "There is no UsageHistory in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var MpListDto = _mapper.Map<List<UsageHistoryDto>>(items);
            var pagination = new Pagination<UsageHistoryDto>(MpListDto, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<UsageHistoryDto>> { IsSuccess = true, Data = pagination };

        }

        public async Task<IServiceResult<EquipmentStatusDto>> ChangeEquipmentStatusAsync(int id, EquipmentStatus newStatus)
        {
            if (id == null && id <= 0)
            {
                return new ServiceResult<EquipmentStatusDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            if (!Enum.IsDefined(typeof(Domain.Concrets.EquipmentStatus), newStatus))
            {
                return new ServiceResult<EquipmentStatusDto> { IsSuccess = false, ErrorMessage = "Invalid Status value" };
            }
            var existEquipment = await _equipmentReadRepository.GetByIdAsync(id);

            if (existEquipment == null)
            {
                return new ServiceResult<EquipmentStatusDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }

            existEquipment.Status = newStatus;
            _equipmentWriteRepository.Update(existEquipment);
            _equipmentWriteRepository.SaveAsync();


            var equipmentStatusDto = _mapper.Map<EquipmentStatusDto>(existEquipment);

            return new ServiceResult<EquipmentStatusDto> { IsSuccess = true, Data = equipmentStatusDto };
        } // done

        public async Task<IServiceResult<Pagination<EquipmentListDto>>> FindByDepartmentId(int? page, int? pageSize, int id)
        {
            if (id == null || id <= 0)
            {
         

                if (page == null && pageSize == null)
                {
                    //var countt = _equipmentReadRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                    int pageValuee = 1;
                    int takeValuee = 10;

                    var equipments = _equipmentReadRepository
                   .GetAll()
                   //.Take(takeValuee)
                   .Where(e => e.IsDeleted == false && e.IsActive == true)
                   .Select(e => new EquipmentListDto
                   {
                       Id = e.Id,
                       Status = e.Status,
                       Name = e.Name,
                       Description = e.Description,
                       LastMaintenace = e.LastMaintenaceDate,
                       CurrentValue = e.CurrentValue,
                       //Model = e.ModelId.HasValue ? e.Model.Name : null,
                       OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
                       //Department = e.DepartmentId.HasValue ? e.Department.Name : null,
                       //Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
                       Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
                       ProductionYear = e.ProductionYear,
                       SeriaNumber = e.SeriaNumber,
                       //UsageLocation = e.usageLocation,
                       MpTime = e.MpCompleted

                   })
                   .ToList();

                    if (equipments == null)
                    {
                        return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
                    }

                    var totalCountt = equipments.Count;
                    var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                    var equipmentListDtoo = _mapper.Map<List<EquipmentListDto>>(equipments);


                    var paginationEquipemnts = new Pagination<EquipmentListDto>(equipmentListDtoo, pageValuee, pageCountt, totalCountt);
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = paginationEquipemnts };
                }

                if ((page <= 0 || pageSize <= 0))
                {
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
                }


                int pageValueee = page.Value;
                int takeValueee = pageSize.Value;
                int skipCountt = (pageValueee > 1) ? (pageValueee - 1) * takeValueee : 0;

                var EquipmentsFromDbb = _equipmentReadRepository.GetAll(tracking: false);

                var itemss = EquipmentsFromDbb
                 .Skip((pageValueee - 1) * takeValueee)
                 .Take(takeValueee)
                 .Where(e => e.IsDeleted == false && e.IsActive == true)
                   .Select(e => new EquipmentListDto
                   {
                       Id = e.Id,
                       Status = e.Status,
                       Name = e.Name,
                       Description = e.Description,  
                       LastMaintenace = e.LastMaintenaceDate,
                       CurrentValue = e.CurrentValue,
                       //Model = e.ModelId.HasValue ? e.Model.Name : null,
                       OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
                       //Department = e.DepartmentId.HasValue ? e.Department.Name : null,
                       //Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
                       Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
                       ProductionYear = e.ProductionYear,
                       SeriaNumber = e.SeriaNumber,
                       //UsageLocation = e.usageLocation,
                       MpTime = e.MpCompleted
                   })
                 .ToList();


                if (itemss == null)
                {
                    return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
                }
                var equipmentCount = EquipmentsFromDbb.Count();
                var totalCounttt = equipmentCount;
                var pageCounttt = (int)Math.Ceiling((double)totalCounttt / takeValueee);

                var equipmentListDtooo = _mapper.Map<List<EquipmentListDto>>(itemss);
                var paginationn = new Pagination<EquipmentListDto>(equipmentListDtooo, pageValueee, pageCounttt, totalCounttt);


                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = paginationn };

                //return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }

            var department = await _departmentReadRepository.GetByIdAsync(id);
            if (department == null)
            {
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Department with this Id in DB" };
            }

            int pageValue = page.Value;
            int takeValue = pageSize.Value;
            int skipCount = (pageValue >= 1) ? (pageValue - 1) * takeValue : 0;

            var EquipmentsFromDb = _equipmentReadRepository.GetAll(tracking: false).Where(e => e.DepartmentId == id);

            var items = EquipmentsFromDb
             .Skip((pageValue - 1) * takeValue)
             .Take(takeValue)
             .Where(e => e.IsDeleted == false && e.IsActive == true && e.DepartmentId == id)
               .Select(e => new EquipmentListDto
               {
                   Id = e.Id,
                   Status = e.Status,
                   Name = e.Name,
                   Description = e.Description,
                   LastMaintenace = e.LastMaintenaceDate,
                   CurrentValue = e.CurrentValue,
                   //Model = e.ModelId.HasValue ? e.Model.Name : null,
                   OperationSite = e.OperationSiteid.HasValue ? e.OperationSite.Name : null,
                   //Department = e.DepartmentId.HasValue ? e.Department.Name : null,
                   //Manufacture = e.ManufactureId.HasValue ? e.Manufacture.Name : null,
                   Type = e.EquipmentTypeId.HasValue ? e.EquipmentType.Name : null,
                   ProductionYear = e.ProductionYear,
                   SeriaNumber = e.SeriaNumber,
                   //UsageLocation = e.usageLocation,
                   MpTime = e.MpCompleted
               })
             .ToList();


            if (items == null)
            {
                return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }
            var equipmentCountt = EquipmentsFromDb.Count();
            var totalCount = equipmentCountt;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var equipmentListDto = _mapper.Map<List<EquipmentListDto>>(items);
            var pagination = new Pagination<EquipmentListDto>(equipmentListDto, pageValue, pageCount, totalCount);


            return new ServiceResult<Pagination<EquipmentListDto>> { IsSuccess = true, Data = pagination };

         


        }   // done


        public async Task<IServiceResult<EquipmentAndMp>> AddMptoEquipment(int? equipmentId, int? Mpid)
        {
            if (equipmentId == null || equipmentId <= 0 || Mpid == null || Mpid <= 0)
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "params is wrong" };
            }

            var existEquipment = _equipmentReadRepository.GetWhere(e => e.Id == equipmentId).Include(e => e.MaintenancePlan);
            if (existEquipment == null)
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }
            var existMp = _readRepository.GetWhere(mp => mp.Id == Mpid).FirstOrDefault();
            if (existMp == null)
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "There is no Mp in DB" };
            }


            var item = existEquipment.FirstOrDefault();

            foreach (var mp in item.MaintenancePlan)
            {
                if (mp.Name == existMp.Name )
                {
                    return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "Equipment already have this Mp" };
                }
            }

            //item.MaintenancePlan.Add(existMp);

            _equipmentWriteRepository.SaveAsync();

            EquipmentMaintenancePlan equipmentAndMp = new EquipmentMaintenancePlan();
            equipmentAndMp.EquipmentId = equipmentId;
            equipmentAndMp.MaintenancePlanid = Mpid;

            //equipmentAndMp.EquipmentName = item.Name;

            var result = await _equipmentMpWriteRepository.AddAsync(equipmentAndMp);

            if (result)
            {
               var endresult = await _equipmentMpWriteRepository.SaveAsync();

                if (endresult<=0)
                {
                    var equDtoss = _mapper.Map<EquipmentAndMp>(equipmentAndMp);
                    return new ServiceResult<EquipmentAndMp> { IsSuccess = true, Data = equDtoss };
                }
            }


            var equDtosss = _mapper.Map<EquipmentAndMp>(equipmentAndMp);

            return new ServiceResult<EquipmentAndMp> { IsSuccess = false, Data= equDtosss };

        }

        public async Task<IServiceResult<List<EquipmentInputDto>>> GetEquipmentsForInput(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                var equipments = _equipmentReadRepository.GetAll()
                    .Include(e => e.EquipmentType)
                    .Where(e => e.IsIdle == true)
                    .Take(5);
                if (equipments == null)
                {
                    return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = false, ErrorMessage = "There is no data in DB" };
                }
                var itemss = equipments.ToList();
               
                var equDto = _mapper.Map<List<EquipmentInputDto>>(itemss);
                return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = true, Data = equDto };
            }
            else
            {
                var equipmentss = _equipmentReadRepository.GetAll().Where(m => m.Name.ToLower().Contains(name.ToLower()) && m.IsIdle == false);
                if (equipmentss == null)
                {
                    return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = true, Data = new List<EquipmentInputDto>() };
                }
                var itemsss = equipmentss.ToList();
                var equDtoss = _mapper.Map<List<EquipmentInputDto>>(itemsss);
                return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = true, Data = equDtoss };
            }
        }
    }
}
