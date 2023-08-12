using Application.Abstraction.Contracts;
using Application.DTOs.Service;
using Application.DTOs.UsageHistory;
using Application.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services
{
    public interface IUsageHistoryService
    {
        
        Task<IServiceResult<UsageHistoryDto>> FindEquipmentUSageAsync(int? id);
        Task<IServiceResult<UsageHistoryCreateDto>> CreateUsageHistoryAsync(UsageHistoryCreateDto usageHistoryCreate);
        Task<IServiceResult<UsageHistoryEndDto>> EndUsageHistoryAsync(UsageHistoryEndDto usageHistoryEnd);

    }
}
