using Application.Repositories.DepartmentRepo;
using Domain.Entities;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.DepartmentRepo
{
    public class DepartmentReadRepository : ReadRepository<Department>, IDepartmentReadRepository
    {
        public DepartmentReadRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }

       
    }
}
