using Application.Repositories.ModelRepo;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ModelRepo
{
    public class ModelReadRepository : ReadRepository<Model>, IModelReadRepository
    {
        public ModelReadRepository(MaintenanceDbContext context) : base(context)
        {
        }
    }
}
