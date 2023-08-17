using Application.Repositories.EquipmentTypeRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.EquipmentTypeRepo
{
    public class EquipmentTypeWriteRepository : WriteRepository<EquipmentType>, IEquipmentTypeWriteRepository
    {
        public EquipmentTypeWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
