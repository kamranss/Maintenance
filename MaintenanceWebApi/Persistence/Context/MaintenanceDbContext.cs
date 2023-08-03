using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class MaintenanceDbContext : IdentityDbContext<AppUser>
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
        public DbSet<Service>? Services { get; set; }
        public DbSet<UsageHistory>? UsageHistories { get; set; }
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
                    new OperationSite { Id = 7, Name = "OperationArea_2", IsDeleted = false, IsActive = true }
                );
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new EquipmentType { Id = 1, Name = "Forklift 1.5", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 2, Name = "Forklift 2.5", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 3, Name = "Forklift 4", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 4, Name = "Forklift 10", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 5, Name = "Forklift 20", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 6, Name = "Reach Stacker 45", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 7, Name = "Portal Crane 80T", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 8, Name = "Portal Crane 40T", IsDeleted = false, IsActive = true },                  
                    new EquipmentType { Id = 9, Name = "Loader 25", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 10, Name = "GC_Berth", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 11, Name = "Ferry_Berth", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 12, Name = "Ro-Ro_Berth", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 13, Name = "Tug_Boat", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 14, Name = "Mobile_Crane 220T", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 15, Name = "Building", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 16, Name = "Container_Spreader", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 17, Name = "Terminal_Tractor", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 18, Name = "Oil_Cleaner_Boat", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 19, Name = "Greifer", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 20, Name = "Lifting_Magnet", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 21, Name = "Fender", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 22, Name = "Railway", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 23, Name = "Wire_Rope_Sling", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 24, Name = "Chain_Connector", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 25, Name = "Lifting_Lug", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 26, Name = "Hook", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 27, Name = "Websling", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 28, Name = "Bunker", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 29, Name = "Generator", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 30, Name = "Shalves", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 31, Name = "Plate_Clamp", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 32, Name = "Harness", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 33, Name = "Roads", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 34, Name = "Drum_Lifter", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 35, Name = "Working_Platform", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 36, Name = "Single leg chain sling", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 37, Name = "Portal Crane 32T", IsDeleted = false, IsActive = true }

                );
            });

        }

    }
}
