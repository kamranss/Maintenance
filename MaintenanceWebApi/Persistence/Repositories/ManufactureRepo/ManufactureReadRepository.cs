using Application.Repositories.ManufactureRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ManufactureRepo
{
    public class ManufactureReadRepository : ReadRepository<Manufacture>, IManufactureReadRepository
    {
        public ManufactureReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
