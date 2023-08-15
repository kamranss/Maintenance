using Application.Repositories.EquipmentPartRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.PartRepo
{
    public class PartWriteRepository : WriteRepository<Part>, IPartWriteRepository
    {
        public PartWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
