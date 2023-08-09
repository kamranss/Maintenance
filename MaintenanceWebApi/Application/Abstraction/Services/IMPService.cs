using Application.Abstraction.Contracts;
using Application.DTOs.Department;
using Application.DTOs.MaintenancePlan;
using Application.DTOs.Service;
using Application.RequestParameters;
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
        Task<IServiceResult<MaintenancePlanCreateDto>> UpdateMPAsync(MaintenancePlanUpdateDto department);
        Task<IServiceResult<MaintenancePlanDto>> DeleteMPAsync(int id);
    }
}
