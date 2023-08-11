using Application.Repositories.ServiceRepo;
using Application.Repositories.UsageHistoryRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.UsageHistoryRepo
{
    public class UsageHistoryWriteRepository : WriteRepository<UsageHistory>, IUsageHistoryWriteRepository
    {
        public UsageHistoryWriteRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
