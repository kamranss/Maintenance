using Application.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Persistence.Concretes;
using Persistence.Context;
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
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Maintenance"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddSingleton<IEquipmentService, EquipmentService>();
            services.AddDbContext<MaintenanceDbContext>(option => option.UseNpgsql("" +
                ""));
        }
    }
}
