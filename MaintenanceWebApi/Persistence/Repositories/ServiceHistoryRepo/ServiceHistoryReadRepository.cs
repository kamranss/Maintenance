using Application.Repositories.ServiceHistoryRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ServiceHistoryRepo
{
    public class ServiceHistoryReadRepository : ReadRepository<ServiceHistory>, IServiceHistoryReadRepository
    {
        public ServiceHistoryReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
