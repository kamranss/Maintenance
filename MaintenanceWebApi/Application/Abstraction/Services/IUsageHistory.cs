using Application.Abstraction.Contracts;
using Application.DTOs.Service;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    partial interface IUsageHistory
    {
        Task<IServiceResult<Pagination<ServiceDto>>> GetUsageHistoryByEquipentIdAsync(int? page, int? take, int? id);
        //Task<IServiceResult<Pagination<ServiceDto>>> FindServicesByMPidAsync(int? page, int? take, int? id);
        Task<IServiceResult<ServiceDto>> FindServiceAsync(int? id);
        Task<IServiceResult<ServiceCreateDto>> CreateUsageHistoryAsync(ServiceCreateDto service);
        //Task<IServiceResult<ServiceUpdateDto>> UpdateServiceAsync(ServiceUpdateDto department);
        //Task<IServiceResult<ServiceDto>> DeleteServiceAsync(int id);
    }
}
