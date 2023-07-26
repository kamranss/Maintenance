using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class MaintenanceDbContext:DbContext
    {
        public MaintenanceDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Equipment>? Equipments { get; set; }
        public DbSet<Part>? Parts { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<MaintenanceAct>? MaintenanceAct { get; set; }
        public DbSet<MaintenancePlan>? MaintenancePlan { get; set; }
        public DbSet<MetricType>? MetricTypes { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<UsageHour>? UsageHours { get; set; }
        public DbSet<EquipmentPart>? EquipmentParts { get; set; }
        public DbSet<EquipmentType> Types { get; set; }
        public DbSet<OperationSite> OperationSites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(DbConfiguration.ConnectionString, b => b.MigrationsAssembly("MaintenanceWebApi"));
            }
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var datas = ChangeTracker
                 .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
