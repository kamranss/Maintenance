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
    public class OperationSiteWriteRepository : WriteRepository<OperationSite>, IWriteOperationSiteRepository
    {
        public OperationSiteWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
