using Application.Repositories;
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
    public class PartReadRepository : ReadRepository<Part>, IPartReadRepository
    {
        public PartReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
