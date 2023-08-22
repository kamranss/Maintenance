using Application.Repositories.EquipmentTypeRepo;
using Application.Repositories.MaintenanceSettingsRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.MaintSettingRepo
{
    public class MSettingsWriteRepository : WriteRepository<MaintenanceSetting>, IMSettingsWriteRepository
    {
        public MSettingsWriteRepository(MaintenanceDbContext maintenanceDbContext) : base(maintenanceDbContext)
        {
        }
    }
}
