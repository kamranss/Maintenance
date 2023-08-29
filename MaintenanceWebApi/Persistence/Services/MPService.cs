using Application.Abstraction.Contracts;
using Application.Abstraction.Services;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Model;
using Application.DTOs.MS;
using Application.DTOs.Service;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.MaintenanceSettingsRepo;
using Application.Repositories.MpRepo;
using Application.RequestParameters;
using AutoMapper;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Repositories.MpRepo;
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
        private readonly IMSettingsWriteRepository _settingsWriteRepository;
        private readonly IMapper _mapper;
        private IMemoryCache _memoryCach;

        public MPService(IMpReadRepository readRepository, IMpWriteRepository writeRepository, IMapper mapper, IMemoryCache memoryCach, IMSettingsWriteRepository settingsWriteRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _memoryCach = memoryCach;
            _settingsWriteRepository = settingsWriteRepository;
        }

        public async Task<IServiceResult<MaintenencePlanStatusDto>> ChangeMpStatusAsync(int id, MaintenencePlanStatus newStatus)
        {
            if (id == null && id <= 0)
            {
                return new ServiceResult<MaintenencePlanStatusDto> { IsSuccess = false, ErrorMessage = "Id is wrong" };
            }
            if (!Enum.IsDefined(typeof(Domain.Concrets.EquipmentStatus), newStatus))
            {
                return new ServiceResult<MaintenencePlanStatusDto> { IsSuccess = false, ErrorMessage = "Invalid Status value" };
            }
            var existMp = await _readRepository.GetByIdAsync(id);

            if (existMp == null)
            {
                return new ServiceResult<MaintenencePlanStatusDto> { IsSuccess = false, ErrorMessage = "There is no Mp with this Id in Db" };
            }

            existMp.Status = newStatus;

            var mpStatusDto = _mapper.Map<MaintenencePlanStatusDto>(existMp);

            return new ServiceResult<MaintenencePlanStatusDto> { IsSuccess = true, Data = mpStatusDto };
        }

        public async Task<IServiceResult<MaintenancePlanCreateDto>> CreateMPAsync(MaintenancePlanCreateDto maintenancePlan)
        {
            if (!Enum.IsDefined(typeof(Metrictype), maintenancePlan.MetricType))
            {
                return new ServiceResult<MaintenancePlanCreateDto> { IsSuccess = false, ErrorMessage = "Invalid MetricType value" };
            }
            var newMp = _mapper.Map<MaintenancePlan>(maintenancePlan);
            newMp.IsActive = true;
            newMp.IsDeleted = true;
            newMp.MetricType = maintenancePlan.MetricType;
            newMp.MetricTypeName = maintenancePlan.MetricType.ToString();


            var result = await _writeRepository.AddAsync(newMp);
            if (result)
            {
                var endresult = await _writeRepository.SaveAsync();

                if (endresult > 0)
                {
                    return new ServiceResult<MaintenancePlanCreateDto> { IsSuccess = true, Data = maintenancePlan };
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

        public async Task<IServiceResult<Pagination<ServiceDto>>> FindServicesByMPidAsync(int? page, int? pagesize, int? id)
        {

            if (page == null && pagesize == null)
            {
                var MpFromDbb = _readRepository.GetWhere(mp => mp.Id == id);
                if (MpFromDbb == null)
                {
                    return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = false, ErrorMessage = "Mp not found" };
                }

                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt / 2;

                var services = _readRepository
               .GetAll()
               .Where(d => d.IsDeleted == false && d.IsActive == true && d.Id == id)
               .Include(mp => mp.Services)
               .Take(takeValuee);
               //./*ToList*/();
                var servicesfromMP = services.Select(item => item.Services).ToList();

                if (servicesfromMP == null)
                {
                    return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = false, ErrorMessage = "There is no Service in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var servicesListDto = _mapper.Map<List<ServiceDto>>(servicesfromMP);
                var paginationServices = new Pagination<ServiceDto>(servicesListDto, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = true, Data = paginationServices };

            }



            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0))
            {
                return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue - 1) * takeValue;


            var MpFromDb = _readRepository.GetWhere(mp => mp.Id == id);
            if (MpFromDb == null)
            {
                return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = false, ErrorMessage = "Mp not found" };
            }

            var items = MpFromDb
                .Include(mp => mp.Services)  // Include related Services
                .Skip((pageValue - 1) * takeValue)
                .Take(takeValue)
                .ToList();

            if (items == null)
            {
                return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = false, ErrorMessage = "There is no Service in DB" };
            }
            var totalCount = items.Count;
            var pageCount = (int)Math.Ceiling((double)totalCount / takeValue);

            var MpListDto = _mapper.Map<List<ServiceDto>>(items);
            var pagination = new Pagination<ServiceDto>(MpListDto, pageValue, pageCount, totalCount);

            return new ServiceResult<Pagination<ServiceDto>> { IsSuccess = true, Data = pagination };
        } // done

        public async Task<IServiceResult<Pagination<MaintenancePlanDto>>> GetMPsAsync(int? page, int? pagesize)
        {

            if (page == null || pagesize == null)
            {
                var countt = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
                int pageValuee = 1;
                int takeValuee = countt / 2;

                var mpss = _readRepository
               .GetAll()
               .Take(takeValuee)
               .Include(d => d.Equipments)
               .Include(d => d.Services)
               .Where(d => d.IsDeleted == false)
               .ToList();

                if (mpss == null)
                {
                    return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "There is no Mp in DB" };
                }

                var totalCountt = countt;
                var pageCountt = (int)Math.Ceiling((double)totalCountt / takeValuee);
                var mpListDto = _mapper.Map<List<MaintenancePlanDto>>(mpss);
                var paginationMp = new Pagination<MaintenancePlanDto>(mpListDto, pageValuee, pageCountt, totalCountt);
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = true, Data = paginationMp };


            }
            if ((!page.HasValue || !pagesize.HasValue || page <= 0 || pagesize <= 0))
            {
                return new ServiceResult<Pagination<MaintenancePlanDto>> { IsSuccess = false, ErrorMessage = "Params is not okay" };
            }
            //int pageValue = page.Value;
            //int takeValue = pagesize.Value;
            //int skipCount = (pageValue - 1) * takeValue;

            var count = _readRepository.GetAll().Where(d => d.IsDeleted == false && d.IsActive == true).Count();
            int pageValue = page.Value;
            int takeValue = pagesize.Value;
            int skipCount = (pageValue > 1) ? (pageValue - 1) * takeValue : 0;

            var MpsFromDb = _readRepository.GetAll(tracking: false);

            var items = MpsFromDb
             .Skip((pageValue - 1) * takeValue)
             .Take(takeValue)
             .Include(d => d.Equipments)
             .Include(d => d.Services)
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

        public async Task<IServiceResult<MpCompleted>> IsMpCompleted(MpCompleted mpCompleted)
        {
            var existMp = _readRepository.GetAll()
                .Include(mp => mp.MaintenanceSettings)
                .Include(mp => mp.Equipments)
                .FirstOrDefault(mp => mp.Id == mpCompleted.MaintenancePlanId);
            if (existMp == null) return new  ServiceResult<MpCompleted> { IsSuccess = false, ErrorMessage = "Mp not found" };


            if (existMp.Equipments == null) return new ServiceResult<MpCompleted> { IsSuccess = false, ErrorMessage = "no Equipnment Assigned to this Mp" };

            var mpSetting = existMp.MaintenanceSettings.FirstOrDefault(s => s.EquipmentId == mpCompleted.EquipmentId);
            var mpEquipment = existMp.Equipments.FirstOrDefault(e => e.Id == mpCompleted.EquipmentId);
            if(mpSetting == null) return new ServiceResult<MpCompleted> { IsSuccess = false, ErrorMessage = "No settings find related to this Equipment" };

            //mpSetting.IsMpCompleted = true;
            mpEquipment.MpCompleted = true;
            var equipment = existMp.Equipments.FirstOrDefault(e => e.Id == mpCompleted.EquipmentId);
            mpSetting.StartValue = equipment.CurrentValue;

            return new ServiceResult<MpCompleted> { IsSuccess = true, Data=mpCompleted };

        }

        public async Task<IServiceResult<MsSetDto>> SetMpSettings(MsSetDto msSetDto)
        {
            if (msSetDto ==null) return new ServiceResult<MsSetDto> { IsSuccess = false, ErrorMessage = "data missing" };
          
            var existMp=  _readRepository.GetAll()
                .Include(mp => mp.Equipments)
                .Include(mp => mp.MaintenanceSettings)
                .FirstOrDefault(mp => mp.Id == msSetDto.MaintenancePlanId);

            if (existMp == null) return new ServiceResult<MsSetDto> { IsSuccess = false, ErrorMessage = "There is no MP with this id" };

           
            if (existMp.Equipments != null)
            {
                var existMpEquipment = existMp.Equipments?.FirstOrDefault(e => e.Id == msSetDto.EquipmentId);
                if (existMpEquipment == null) return new ServiceResult<MsSetDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this id in this Mp" };
                var msDto = _mapper.Map<MaintenanceSetting>(msSetDto);
                msDto.StartValue = existMpEquipment.CurrentValue;
                msDto.IsMpCompleted = true;
                existMp.MaintenanceSettings.Add(msDto);
               var result =  _settingsWriteRepository.SaveAsync();
                //Console.WriteLine("salam");
                //Console.WriteLine(result);
                return new ServiceResult<MsSetDto> { IsSuccess = true, Data = msSetDto };
                //return new ServiceResult<MsSetDto> { IsSuccess = false, ErrorMessage = "Something went wrong" };
            }

            //var msDtoo = _mapper.Map<MaintenanceSetting>(msSetDto);
            //msDtoo.StartValue = existMpEquipment.CurrentValue;
            //existMp.MaintenanceSettings.Add(msDtoo);
            //return new ServiceResult<MsSetDto> { IsSuccess = false, Data = msSetDto };
            return new ServiceResult<MsSetDto> { IsSuccess = false, ErrorMessage = "There is no Equipment with this id in this Mp" };


        } // Save method is not working 

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
        } // doner

    
    }
}
