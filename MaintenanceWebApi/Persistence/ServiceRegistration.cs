﻿using Application.Abstraction.EquipmentS;
using Application.Repositories.EquipmentRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Concretes.Equipment;
using Persistence.Configuration;
using Persistence.Context;
using Persistence.Repositories.EquipmentRepo;
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
            services.AddSingleton<IEquipmentService, EquipmentService>();
            services.AddDbContext<MaintenanceDbContext>(option => option.UseNpgsql(DbConfiguration.ConnectionString));
            services.AddScoped<IEquipmentReadRepository, EquipmentReadRepository>();
            services.AddScoped<IEquipmentWriteRepository, EquipmentWriteRepository>();
        }
    }
}
