using Application.Repositories.ServiceRepo;
using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories.UsageHistoryRepo;
using Persistence.Context;

namespace Persistence.Repositories.UsageHistoryRepo
{
    public class UsageHistoryReadRepository : ReadRepository<UsageHistory>, IUsageHistoryReadRepository
    {
        public UsageHistoryReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
