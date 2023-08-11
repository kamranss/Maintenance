using Application.Repositories.DepartmentRepo;
using Application.Repositories.ServiceRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ServiceRepo
{
    public class ServiceReadRepository : ReadRepository<Service>, IServiceReadRepository
    {
        public ServiceReadRepository(MaintenanceDbContext context) : base(context)
        {
        }

      
    }
}
