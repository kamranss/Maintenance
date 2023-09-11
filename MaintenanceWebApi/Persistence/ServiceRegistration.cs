using Application.Abstraction.Services;
using Application.Abstraction.Services.Authentications;
using Application.Mapper.Profiles;
using Application.Repositories.DepartmentRepo;
using Application.Repositories.EquipmentMpRepo;
using Application.Repositories.EquipmentPartRepo;
using Application.Repositories.EquipmentRepo;
using Application.Repositories.EquipmentTypeRepo;
using Application.Repositories.MaintenanceSettingsRepo;
using Application.Repositories.ManufactureRepo;
using Application.Repositories.ModelRepo;
using Application.Repositories.MpRepo;
using Application.Repositories.OperationSiteRepo;
using Application.Repositories.ServiceHistoryRepo;
using Application.Repositories.ServiceRepo;
using Application.Repositories.UsageHistoryRepo;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;
using Persistence.Context;
using Persistence.Helper;
using Persistence.Repositories.DepartmentRepo;
using Persistence.Repositories.EquipmentMpRepo;
using Persistence.Repositories.EquipmentRepo;
using Persistence.Repositories.EquipmentTypeRepo;
using Persistence.Repositories.MaintSettingRepo;
using Persistence.Repositories.ManufactureRepo;
using Persistence.Repositories.ModelRepo;
using Persistence.Repositories.MpRepo;
using Persistence.Repositories.OperationSiteRepo;
using Persistence.Repositories.PartRepo;
using Persistence.Repositories.ServiceHistoryRepo;
using Persistence.Repositories.ServiceRepo;
using Persistence.Repositories.UsageHistoryRepo;
using Persistence.Services;
using Persistence.Services.Account;
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
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.SignIn.RequireConfirmedEmail = true;

                options.User.RequireUniqueEmail = true;
                options.Lockout.AllowedForNewUsers = true;

                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            }).AddEntityFrameworkStores<MaintenanceDbContext>()
              .AddDefaultTokenProviders()
              .AddErrorDescriber<CustomidentityErrorDescriber>(); // this is serving for get error descriptions which we indicated within helper 

            services.AddScoped<UserManager<AppUser>>();
            services.AddAutoMapper(option =>
            {
                option.AddProfile<MapProfile>();
            }); // Config for Automapper package


            services.AddScoped<IEquipmentReadRepository, EquipmentReadRepository>();
            services.AddScoped<IEquipmentWriteRepository, EquipmentWriteRepository>();

            services.AddScoped<IEquipmentMpReadRepository, EquipmentMpReadRepository>();
            services.AddScoped<IEquipmentMpWriteRepository, EquipmentMpWriteRepository>();

            services.AddScoped<IDepartmentReadRepository, DepartmentReadRepository>();
            services.AddScoped<IDepartmentWriteRepository, DepartmentWriteRepository>();

            services.AddScoped<IMpReadRepository, MpReadRepository>();
            services.AddScoped<IMpWriteRepository, MpWriteRepository>();

            services.AddScoped<IManufactureReadRepository, ManufactureReadRepository>();
            services.AddScoped<IManufactureWriteRepository, ManufactureWriteRepository>();

            services.AddScoped<IServiceReadRepository, ServiceReadRepository>();
            services.AddScoped<IServiceWriteRepository, ServiceWriteRepository>();

            services.AddScoped<IUsageHistoryReadRepository, UsageHistoryReadRepository>();
            services.AddScoped<IUsageHistoryWriteRepository, UsageHistoryWriteRepository>();

            services.AddScoped<IModelReadRepository, ModelReadRepository>();
            services.AddScoped<IModelWriteRepository, ModelWriteRepository>();

            services.AddScoped<IReadOperationSiteRepository, OperationSiteReadRepository>();
            services.AddScoped<IWriteOperationSiteRepository, OperationSiteWriteRepository>();

            services.AddScoped<IPartReadRepository, PartReadRepository>();
            services.AddScoped<IPartWriteRepository, PartWriteRepository>();

            services.AddScoped<IEquipmentTypeReadRepository, EquipmentTypeReadRepository>();
            services.AddScoped<IEquipmentTypeWriteRepository, EquipmentTypeWriteRepository>();

            services.AddScoped<IMSettingsReadRepository, MSettingsReadRepository>();
            services.AddScoped<IMSettingsWriteRepository, MSettingsWriteRepository>();

            services.AddScoped<IServiceHistoryReadRepository, ServiceHistoryReadRepository>();
            services.AddScoped<IServiceHistoryWriteRepository, ServiceHistoryWriteRepository>();

            

            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IMPService, MPService>();
            services.AddScoped<IServeServices, ServeService>();
            services.AddScoped<IUsageHistoryService, UsageHistoryService>();
            services.AddScoped<IManufactureService, ManufactureService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IOperationSiteService, OperationSiteService>();
            services.AddScoped<IPartService, PartService>();
            services.AddScoped<IEquipmentTypeService, EquipmentTypeService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFileService, FileService>();

        }
    }
}
