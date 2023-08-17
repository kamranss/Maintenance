﻿using Application.Abstraction.Contracts;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Application.RequestParameters;
using Domain.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IMPService
    {
        Task<IServiceResult<Pagination<MaintenancePlanDto>>> GetMPsAsync(int? page, int? pageSize);
        Task<IServiceResult<MaintenancePlanDto>> FindMPAsync(int? id);
        Task<IServiceResult<MaintenancePlanCreateDto>> CreateMPAsync(MaintenancePlanCreateDto service);
        Task<IServiceResult<MaintenancePlanUpdateDto>> UpdateMPAsync(MaintenancePlanUpdateDto department);
        Task<IServiceResult<Pagination<ServiceDto>>> FindServicesByMPidAsync(int? page, int? take, int? id);
        Task<IServiceResult<MaintenancePlanDto>> DeleteMPAsync(int id);
        Task<IServiceResult<MaintenencePlanStatusDto>> ChangeMpStatusAsync(int id, MaintenencePlanStatus newStatus);
        //Task<IServiceResult<MaintenencePlanStatusDto>> AddServicesToMP(int id, MaintenencePlanStatus newStatus);
    }
}
