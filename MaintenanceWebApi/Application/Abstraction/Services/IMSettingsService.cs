using Application.Abstraction.Contracts;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.MS;
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
    public interface IMSettingsService
    {
        Task<IServiceResult<MsSetDto>> SetMStoMpAsync(MsSetDto? id);
        Task<IServiceResult<MsUpdateDto>> UpdateMsAsync(MsUpdateDto? id);

        Task<IServiceResult<bool>> CheckALLMpSetting();


        //Task<IServiceResult<MaintenancePlanCreateDto>> CreateMPAsync(MaintenancePlanCreateDto service);
        //Task<IServiceResult<MaintenancePlanUpdateDto>> UpdateMPAsync(MaintenancePlanUpdateDto department);
        //Task<IServiceResult<Pagination<ServiceDto>>> FindServicesByMPidAsync(int? page, int? take, int? id);
        //Task<IServiceResult<MaintenancePlanDto>> DeleteMPAsync(int id);
        //Task<IServiceResult<MaintenencePlanStatusDto>> ChangeMpStatusAsync(int id, MaintenencePlanStatus newStatus);
    }
}
