using Application.Repositories;
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
    internal class EquipmentWriteRepository : WriteRepository<Equipment>, IEquipmentWriteRepository
    {
        public EquipmentWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
