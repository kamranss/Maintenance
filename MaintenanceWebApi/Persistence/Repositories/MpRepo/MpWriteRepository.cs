using Application.Repositories.MpRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.MpRepo
{
    public class MpWriteRepository : WriteRepository<MaintenancePlan>, IMpWriteRepository
    {
        public MpWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
