using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Manufacture;
using Application.DTOs.MS;
using Application.DTOs.Parts;
using Application.DTOs.Service;
using Application.DTOs.UsageHistory;
using Application.Exceptions.EquipmentException;
using Application.Helpers.FileExten;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.EquipmentMpRepo;
using Application.Repositories.EquipmentPartRepo;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.ManufactureRepo;
using Application.Repositories.ModelRepo;
using Application.Repositories.MpRepo;
using Application.Repositories.OperationSiteRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
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
        private readonly IMpWriteRepository _writeRepository;
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
        private readonly IPartReadRepository _partReadRepository;
        private readonly IPartWriteRepository _partWriteRepository;
        private readonly ILogger<EquipmentService> _logger;


        public EquipmentService(IEquipmentReadRepository? equipmentReadRepository, IEquipmentWriteRepository? equipmentWriteRepository, IMapper mapper, IMemoryCache memoryCach, IWebHostEnvironment webHostEnvironment, IMpReadRepository readRepository, IModelReadRepository modelReadRepository, IManufactureReadRepository manufactureReadRepository, IDepartmentReadRepository departmentReadRepository, IReadOperationSiteRepository readOperationSiteRepository, IEquipmentMpReadRepository equipmentMpReadRepository, IEquipmentMpWriteRepository equipmentMpWriteRepository, IMpWriteRepository writeRepository, IPartReadRepository partReadRepository, IPartWriteRepository partWriteRepository, ILogger<EquipmentService> logger)
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
            _writeRepository = writeRepository;
            _partReadRepository = partReadRepository;
            _partWriteRepository = partWriteRepository;
            _logger = logger;
        }

        public async Task<IServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment)
        {
            try
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
                        //return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = "Invalid UsageLocation value" };
                        throw new Exception("Invalid UsageLocation value");
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
                        _logger.LogInformation("Equipment created successfully: {EquipmentId}", newEquipment.Id);
                        return new ServiceResult<EquipmentCreateDto> { IsSuccess = true, Data = equipment };


                    }
                    throw new Exception("Equipment could not be saved.");
                }


                throw new Exception("Equipment could not be added.");


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating equipment: {ErrorMessage}", ex.Message);
                return new ServiceResult<EquipmentCreateDto> { IsSuccess = false, ErrorMessage = $"Equipment could not be added: {ex.Message}" };
            }

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
            var query = _equipmentReadRepository
                .GetAll()
                .Where(e => e.Id == id)
                .Include(e => e.Department)
                .Include(e => e.Manufacture)
                .Include(e => e.OperationSite)
                .Include(e => e.Model)
                .Include(e => e.EquipmentType)
                .Include(e => e.MaintenanceSettings)
                .Include(e => e.UsageHistories)
                .Include(e => e.Part)
                .Include(e => e.MaintenancePlan)
                .ThenInclude(mp => mp.MaintenanceSettings);

            var sql = await query.ToListAsync(); 

            var equipment = query.FirstOrDefault();

            if (equipment != null)
            {
    
                equipment.MaintenancePlan.ForEach(mp =>
                {
                    if (mp.MaintenanceSettings == null)
                    {
                        mp.MaintenanceSettings = new List<MaintenanceSetting>();
                    }
                    mp.MaintenanceSettings = mp.MaintenanceSettings
                       .Where(ms => ms.EquipmentId == equipment.Id)
                       .ToList();
                });


            }
            else
            {
                return new ServiceResult<EquipmentDetailDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this Id in Db" };
            }

            Console.WriteLine(equipment);

          

            EquipmentDetailDto equipmentDetailDto = new EquipmentDetailDto();

         
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
            equipmentDetailDto.SettingList = equipment.MaintenanceSettings != null ? _mapper.Map<List<MsDto>>(equipment.MaintenanceSettings) : null;
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
            var result = _equipmentWriteRepository.Update(existEquipment);

            if (result)
            {
               var endResult =  await _equipmentWriteRepository.SaveAsync();
                if (endResult>0)
                {
                    var equipmentStatusDto = _mapper.Map<EquipmentStatusDto>(existEquipment);
                    return new ServiceResult<EquipmentStatusDto> { IsSuccess = true, Data = equipmentStatusDto };
                }
            }

            return new ServiceResult<EquipmentStatusDto> { IsSuccess = false, ErrorMessage = "Something went Wrong" };

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
                    .OrderBy(e => e.MpTime.HasValue && e.MpTime.Value ? 1 : 0)
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
                   .OrderBy(e => e.MpTime.HasValue && e.MpTime.Value ? 1 : 0)
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
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "params are wrong" };
            }

            // Retrieve the Equipment and MaintenancePlan entities
            var equipment = await _equipmentReadRepository.GetWhere(e => e.Id == equipmentId)
                .Include(e => e.MaintenancePlan)
                .FirstOrDefaultAsync();

            if (equipment == null)
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }

            var maintenancePlan = await _readRepository.GetWhere(mp => mp.Id == Mpid).FirstOrDefaultAsync();

            if (maintenancePlan == null)
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "There is no MaintenancePlan in DB" };
            }

            // Check if the MaintenancePlan is already associated with the Equipment
            if (equipment.MaintenancePlan.Contains(maintenancePlan))
            {
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "Equipment already has this MaintenancePlan" };
            }

            // Associate the MaintenancePlan with the Equipment (EF Core will handle the insertion into the junction table)
            equipment.MaintenancePlan.Add(maintenancePlan);

            try
            {
                await _equipmentWriteRepository.SaveAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
                Console.WriteLine(ex);
                return new ServiceResult<EquipmentAndMp> { IsSuccess = false, ErrorMessage = "Failed to save changes" };
            }

            // Create a result object or perform additional actions as needed
            var equipmentAndMp = new EquipmentAndMp
            {
                EquipmentId = equipmentId,
                MpId = Mpid,
                EquipmentName = equipment.Name,
            };

            return new ServiceResult<EquipmentAndMp> { IsSuccess = true, Data = equipmentAndMp };

        }

        public async Task<IServiceResult<List<EquipmentInputDto>>> GetEquipmentsForInput(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                var equipments = _equipmentReadRepository.GetAll()
                    .Include(e => e.EquipmentType)
                    .Where(e => e.IsIdle == true && e.IsActive == true && e.Status == EquipmentStatus.ACTIVE)
                    .Take(10);
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
                var equipmentss = _equipmentReadRepository.GetAll().Where(e => e.Name.ToLower().Contains(name.ToLower()) && e.IsIdle == true && e.IsActive==true && e.Status== EquipmentStatus.ACTIVE);
                if (equipmentss == null)
                {
                    return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = true, Data = new List<EquipmentInputDto>() };
                }
                var itemsss = equipmentss.ToList();
                var equDtoss = _mapper.Map<List<EquipmentInputDto>>(itemsss);
                return new ServiceResult<List<EquipmentInputDto>> { IsSuccess = true, Data = equDtoss };
            }
        }

        public async Task<IServiceResult<EquipmentAndPart>> AddParttoEquipment(int? equipmentId, int? partId)
        {
            if (equipmentId == null || equipmentId <= 0 || partId == null || partId <= 0)
            {
                return new ServiceResult<EquipmentAndPart> { IsSuccess = false, ErrorMessage = "params are wrong" };
            }

            // Retrieve the Equipment and MaintenancePlan entities
            var equipment = await _equipmentReadRepository.GetWhere(e => e.Id == equipmentId)
                .Include(e => e.Part)
                .FirstOrDefaultAsync();

            if (equipment == null)
            {
                return new ServiceResult<EquipmentAndPart> { IsSuccess = false, ErrorMessage = "There is no Equipment in DB" };
            }

            var part = await _partReadRepository.GetWhere(p => p.Id == partId).FirstOrDefaultAsync();

            if (part == null)
            {
                return new ServiceResult<EquipmentAndPart> { IsSuccess = false, ErrorMessage = "There is no part in DB" };
            }

            // Check if the MaintenancePlan is already associated with the Equipment
            if (equipment.Part.Contains(part))
            {
                return new ServiceResult<EquipmentAndPart> { IsSuccess = false, ErrorMessage = "Equipment already has this part" };
            }

            // Associate the MaintenancePlan with the Equipment (EF Core will handle the insertion into the junction table)
            equipment.Part.Add(part);

            try
            {
                await _equipmentWriteRepository.SaveAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
                Console.WriteLine(ex);
                return new ServiceResult<EquipmentAndPart> { IsSuccess = false, ErrorMessage = "Failed to save changes" };
            }

            // Create a result object or perform additional actions as needed
            var equipmentAndpart = new EquipmentAndPart
            {
                EquipmentId = equipmentId,
                PartId = partId,
                EquipmentName = equipment.Name,
                PartName = part.Name,
            };

            return new ServiceResult<EquipmentAndPart> { IsSuccess = true, Data = equipmentAndpart };
        }
    }
}
