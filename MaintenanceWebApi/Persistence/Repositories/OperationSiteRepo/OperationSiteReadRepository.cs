using Application.Repositories.OperationSiteRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.OperationSiteRepo
{
    public class OperationSiteReadRepository : ReadRepository<OperationSite>, IReadOperationSiteRepository
    {
        public OperationSiteReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
