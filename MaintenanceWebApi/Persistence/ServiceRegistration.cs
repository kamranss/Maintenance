using Application.Abstraction.Services;
using Application.Mapper.Profiles;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.EquipmentRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;
using Persistence.Context;
using Persistence.Repositories.DepartmentRepo;
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
            services.AddMemoryCache();
            services.AddDbContext<MaintenanceDbContext>(option => option.UseNpgsql(DbConfiguration.ConnectionString));

            services.AddAutoMapper(option =>
            {
                option.AddProfile<MapProfile>();
            }); // Config for Automapper package










            services.AddScoped<IEquipmentReadRepository, EquipmentReadRepository>();
            services.AddScoped<IEquipmentWriteRepository, EquipmentWriteRepository>();
            services.AddScoped<IDepartmentReadRepository, DepartmentReadRepository>();
            services.AddScoped<IDepartmentWriteRepository, DepartmentWriteRepository>();

            services.AddScoped<IDepartmentService, DepartmentService>();
            //services.AddScoped<IEquipmentService, EquipmentService>();
        }
    }
}
