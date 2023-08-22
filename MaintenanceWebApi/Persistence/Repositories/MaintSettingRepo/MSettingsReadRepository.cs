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
    public class MSettingsReadRepository : ReadRepository<MaintenanceSetting>, IMSettingsReadRepository
    {
        public MSettingsReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
