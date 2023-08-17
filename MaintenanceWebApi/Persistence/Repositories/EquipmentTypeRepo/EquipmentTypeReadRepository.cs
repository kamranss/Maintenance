using Application.Repositories.EquipmentRepo;
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
    public class EquipmentTypeReadRepository : ReadRepository<EquipmentType>, IEquipmentTypeReadRepository
    {
        public EquipmentTypeReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
