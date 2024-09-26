using Application.Repositories.UnPlannedMpRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.UnPlannedMpRepo
{
    public class UnPlannedMpReadRepository : ReadRepository<UnPlannedMp>, IUnPlannedMpReadRepository
    {
        public UnPlannedMpReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
