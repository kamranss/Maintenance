using Application.Abstraction.Services;
using Application.Repositories.EquipmentRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;
using Persistence.Context;
using Persistence.Repositories.EquipmentRepo;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
         
            services.AddDbContext<MaintenanceDbContext>(option => option.UseNpgsql(DbConfiguration.ConnectionString));
            services.AddScoped<IEquipmentReadRepository, EquipmentReadRepository>();
            services.AddScoped<IEquipmentWriteRepository, EquipmentWriteRepository>();



            services.AddScoped<IEquipmentService, EquipmentService>();
        }
    }
}
