using Application.Repositories.EquipmentRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.EquipmentRepo
{
    public class EquipmentReadRepository : ReadRepository<Equipment>, IEquipmentReadRepository
    {
        public EquipmentReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
