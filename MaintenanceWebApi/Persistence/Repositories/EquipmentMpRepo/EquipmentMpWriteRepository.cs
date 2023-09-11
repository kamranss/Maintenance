using Application.Repositories.EquipmentMpRepo;
using Application.Repositories.EquipmentRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.EquipmentMpRepo
{
    public class EquipmentMpWriteRepository : WriteRepository<EquipmentMaintenancePlan>, IEquipmentMpWriteRepository
    {
        public EquipmentMpWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
