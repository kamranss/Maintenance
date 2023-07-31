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
        //public DbSet<EquipmentType> Types { get; set; }
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

 
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for departments
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new Department { Id = 1, Name = "Planning", IsDeleted = false, IsActive = true },
                    new Department { Id = 2, Name = "Takelaj", IsDeleted = false, IsActive = true },
                    new Department { Id = 3, Name = "Operation", IsDeleted = false, IsActive = true },
                    new Department { Id = 4, Name = "Electrical", IsDeleted = false, IsActive = true },
                    new Department { Id = 5, Name = "MarineFleet", IsDeleted = false, IsActive = true },
                    new Department { Id = 6, Name = "Mechanical", IsDeleted = false, IsActive = true },
                    new Department { Id = 7, Name = "Cranes", IsDeleted = false, IsActive = true },
                    new Department { Id = 8, Name = "Railway", IsDeleted = false, IsActive = true },
                    new Department { Id = 9, Name = "Transport", IsDeleted = false, IsActive = true },
                    new Department { Id = 10, Name = "Engineering", IsDeleted = false, IsActive = true },
                    new Department { Id = 11, Name = "Berth", IsDeleted = false, IsActive = true }

                );
            });
            modelBuilder.Entity<OperationSite>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new OperationSite { Id = 1, Name = "Building_1", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 2, Name = "Building_2", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 3, Name = "OperationArea_1", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 4, Name = "WareHause_1", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 5, Name = "WareHause_2", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 6, Name = "WareHause_3", IsDeleted = false, IsActive = true },
                    new OperationSite { Id = 7, Name = "OperationArea_2", IsDeleted = false, IsActive = true },
                );
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new EquipmentType { Id = 1, Name = "Building_1", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 2, Name = "Building_2", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 1, Name = "OperationArea_1", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 1, Name = "WareHause_1", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 1, Name = "WareHause_2", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 1, Name = "WareHause_3", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 1, Name = "OperationArea_2", IsDeleted = false, IsActive = true },
                );
            });

        }

    }
}
