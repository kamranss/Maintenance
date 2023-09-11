using Domain.Common;
using Domain.Concrets;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
        //public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<MaintenanceAct>? MaintenanceAct { get; set; }
        public DbSet<MaintenancePlan>? MaintenancePlan { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<UsageHistory>? UsageHistories { get; set; }
        public DbSet<EquipmentPart>? EquipmentParts { get; set; }
        //public DbSet<EquipmentType> Types { get; set; }
        public DbSet<OperationSite>? OperationSites { get; set; }
        public DbSet<Model>? Models { get; set; }
        public DbSet<Manufacture>? Manufactures { get; set; }
        public DbSet<MaintenanceSetting> MaintenanceSettings { get; set; }
        //public DbSet<EquipmentMaintenancePlan> EquipmentMaintenancePlans { get; set; }

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
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            // Seed data for departments

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new Department { Id = 1, Name = "Planning", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System", DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 2, Name = "Takelaj", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System", DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 3, Name = "Operation", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 4, Name = "Electrical", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 5, Name = "MarineFleet", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 6, Name = "Mechanical", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 7, Name = "Cranes", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System"  , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 8, Name = "Railway", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 9, Name = "Transport", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1", Description = "Unknown" },
                    new Department { Id = 10, Name = "Engineering", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1" , Description = "Unknown" },
                    new Department { Id = 11, Name = "Berth", IsDeleted = false, IsActive = true , CreatedDate = DateTime.UtcNow, CreatedBy = "System" , DepartmentHead = "User1" , Description = "Unknown" }

                );
            });

            modelBuilder.Entity<OperationSite>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new OperationSite { Id = 1, Name = "Building_1", IsDeleted = false, IsActive = true, DepartmentId=1, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 2, Name = "Building_2", IsDeleted = false, IsActive = true, DepartmentId = 1, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 3, Name = "OperationArea_1", IsDeleted = false, IsActive = true, DepartmentId = 1, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 4, Name = "WareHause_1", IsDeleted = false, IsActive = true, DepartmentId = 5, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 5, Name = "WareHause_2", IsDeleted = false, IsActive = true, DepartmentId = 5, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 6, Name = "WareHause_3", IsDeleted = false, IsActive = true, DepartmentId = 6, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 7, Name = "OperationArea_2", IsDeleted = false, IsActive = true, DepartmentId = 3, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 8, Name = "ST-1", IsDeleted = false, IsActive = true, DepartmentId = 2, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 9, Name = "ST-2", IsDeleted = false, IsActive = true, DepartmentId = 2, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 10, Name = "ST-3", IsDeleted = false, IsActive = true, DepartmentId = 3, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 11, Name = "ST-4", IsDeleted = false, IsActive = true, DepartmentId = 3, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new OperationSite { Id = 12, Name = "ST-5", IsDeleted = false, IsActive = true, DepartmentId = 4, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }

                );
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new EquipmentType { Id = 1, Name = "Forklift 1.5", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 2, Name = "Forklift 2.5", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 3, Name = "Forklift 4", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 4, Name = "Forklift 10", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 5, Name = "Forklift 20", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 6, Name = "Reach Stacker 45", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 7, Name = "Portal Crane 80T", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 8, Name = "Portal Crane 40T", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },                  
                    new EquipmentType { Id = 9, Name = "Loader 25", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 10, Name = "GC_Berth", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 11, Name = "Ferry_Berth", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 12, Name = "Ro-Ro_Berth", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 13, Name = "Tug_Boat", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 14, Name = "Mobile_Crane 220T", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 15, Name = "Building", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 16, Name = "Container_Spreader", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 17, Name = "Terminal_Tractor", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 18, Name = "Oil_Cleaner_Boat", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 19, Name = "Greifer", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 20, Name = "Lifting_Magnet", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 21, Name = "Fender", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 22, Name = "Railway", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 23, Name = "Wire_Rope_Sling", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 24, Name = "Chain_Connector", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 25, Name = "Lifting_Lug", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 26, Name = "Hook", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 27, Name = "Websling", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 28, Name = "Bunker", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 29, Name = "Generator", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 30, Name = "Shalves", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 31, Name = "Plate_Clamp", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 32, Name = "Harness", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 33, Name = "Roads", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 34, Name = "Drum_Lifter", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 35, Name = "Working_Platform", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 36, Name = "Single leg chain sling", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 37, Name = "Portal Crane 32T", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }

                );
            });

            modelBuilder.Entity<Manufacture>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new EquipmentType { Id = 1, Name = "Single leg chain sling", IsDeleted = false, IsActive = true, CreatedDate=DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 2, Name = "Working platform", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 3, Name = "Hangcha", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 4, Name = "XCMG", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 5, Name = "Kalmar", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 6, Name = "Terberq", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 7, Name = "Sisu", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 8, Name = "Toyoto", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 9, Name = "Bobkat", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 10, Name = "Hyster", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 11, Name = "Boss", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 12, Name = "Ardelt", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 13, Name = "None", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 14, Name = "VDL", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 15, Name = "Sunny", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 16, Name = "Camry", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 17, Name = "Engine", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 18, Name = "023-2 №-li dizel generator", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 19, Name = "022-1 №-li dizel generator", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 20, Name = "021-TQM 23 B48-754", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 21, Name = "Service berth-N4", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 22, Name = "Molino", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 23, Name = "Service berth-N3 ", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 24, Name = "Shackle", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 25, Name = "County", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 26, Name = "Santafe", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 27, Name = "Sonata", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 28, Name = "Kartal SLX", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }                   

                );
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                   new EquipmentType { Id = 1, Name = "RS45-31CH", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 2, Name = "CPCD200-W36", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 3, Name = "CPCD100-W17", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 4, Name = "CPCD40-RC24", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 5, Name = "CPCD25N-RC2", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 6, Name = "CPCD15N-RC26", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 7, Name = "XT760", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 8, Name = "DRD420-60S5", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 9, Name = "DSD420-12CSG", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 10, Name = "T-1", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 11, Name = "TV-10EIT-4x4/2600", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 12, Name = "FD-100F50", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 13, Name = "843", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 14, Name = "HS1", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 15, Name = "B1", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 16, Name = "FD-15", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 17, Name = "Kondor 1500", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 18, Name = "QAY220 All Terrain Crane", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 19, Name = "None", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 20, Name = "Sokol 500", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 21, Name = "Mobil Pnevmatik Transporter", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 22, Name = "ST 1", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 23, Name = "ST 2", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 24, Name = "ST 3", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 25, Name = "ST 4", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 26, Name = "ST 4", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 27, Name = "ST 5", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 28, Name = "ST 6", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 29, Name = "ST 7", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 30, Name = "ST 8", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 31, Name = "ST 8", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 32, Name = "ST 9", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 33, Name = "ST 10", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 34, Name = "Ferry Terminal", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 35, Name = "YT180-04", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 36, Name = "CH 6600", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 37, Name = "AM 140/76/36", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 38, Name = "VSG/020.0-2.2-6400", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 39, Name = "VSG/015.0.07.13500", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 40, Name = "VSG/016.0-2.2-5000", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 41, Name = "VSG/020.0-0.7-17500", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 42, Name = "Sabir Babayev yedək gəmisi", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 43, Name = "Ələt yedək gəmisi", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 44, Name = "Silkway yedək gəmisi", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 45, Name = "045-TQM 23 B - 48", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 46, Name = "046-MNMS-73", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 47, Name = "047-Şəfəq", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 48, Name = "048-Kür", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 49, Name = "049-Günəşli", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 50, Name = "050-Nüsrət Şirinov", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 51, Name = "051-Elxan Kazımov", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 52, Name = "052-Limançı", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 53, Name = "053-TQM 23 B48 - 2494", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 54, Name = "Nissan", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 55, Name = "Toyota", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 56, Name = "QAZ", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 57, Name = "HOWO", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 58, Name = "Fiat", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 59, Name = "111111", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 60, Name = "Vaz", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 61, Name = "Tofash", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 62, Name = "Volkswagen", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 63, Name = "Hyundai", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 64, Name = "Mersedes Benz", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 65, Name = "5 Tonne 5mtr x 26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 66, Name = "5 Tonne 4mtr x 26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 67, Name = "10 Tonne 5.5mtr x 32mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 68, Name = "15 Tonne 4mtr x 38mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 69, Name = "5 Tonne 3mtr x 26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 70, Name = "8.6 Tonne 1.9mtr x26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 71, Name = "8.6 Tonne 10 mtr x 26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 72, Name = "6.2 Tonne 11.06mtr x 22mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 73, Name = "8.6 Tonne 10 mtr x 26mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 74, Name = "6.2 Tonne 11.06mtr x 22mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 75, Name = "6.2 Tonne 10 mtr x 22mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 76, Name = "6.2 Tonne 6 mtr x 22 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 77, Name = "077-5.1 6 mtr x 22 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 78, Name = "078-5.1 Tonne 1.3 mtr x 20 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 79, Name = "079-5.1 Tonne 2.93 mtr x 20 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 80, Name = "080-10.1 Tonne 12 mtr x 28 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 81, Name = "081-5 Tonne 8 mtr x 20 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 82, Name = "082-8 Tonne 8 mtr x 26 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 83, Name = "083-10 Tonne 10 mtr x 28 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 84, Name = "084-10.1 Tonne 6 mtr x 28 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 85, Name = "085-10.1 Tonne 6 mtr x 28 mm dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 86, Name = "086-12 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 87, Name = "087-25 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 88, Name = "6.5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 89, Name = "4.75 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 90, Name = "3.25 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 91, Name = "8.5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 92, Name = "12 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 93, Name = "12.5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 94, Name = "8 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 95, Name = "3 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 96, Name = "10 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 97, Name = "4064 Kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 98, Name = "5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 99, Name = "3 Tonne 1 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 100, Name = "3 Tonne 2 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 101, Name = "3 Tonne 2 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 102, Name = "3 Tonne 3 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 103, Name = "3 Tonne 5 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 104, Name = "3 Tonne 6 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 105, Name = "3 Tonne 10 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 106, Name = "106-5 tonne 3 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 107, Name = "107-5 Tonne 5 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 108, Name = "108-5 Tonne 6 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 109, Name = "109-10 Tonne 5 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 110, Name = "110-6 Tonne 4 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 111, Name = "6 Tonne 6 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 112, Name = "112-6 Tonne 10mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 113, Name = "113-14 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 114, Name = "114-15 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 115, Name = "115-136 kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 116, Name = "116-30 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 117, Name = "117-Model: H2000/3 MFB", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 118, Name = "118-Model: KP 25", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 119, Name = "119-Model: 71022", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 120, Name = "120-2250 kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 121, Name = "121-1.5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 122, Name = "122-SİNGLE LİNE LANYARD", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 123, Name = "123-Takelaj sahəsi", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 124, Name = "8 Tonne 8 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 125, Name = "8 Tonne 6mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 126, Name = "126- Qarmaq   KE-40", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 127, Name = "127-Qarmaq    KE-80", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 128, Name = "128-Qarmaq   KE-32", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 129, Name = "10 Tonee x 3 mtr x 28 dia", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 130, Name = "3 tonne x 1.5 mtr x 20 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 131, Name = "7 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 132, Name = "3 tonne x 1 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 133, Name = "10 Tonne 6 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 134, Name = "10 tonne 4 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 135, Name = "1 tonne 2mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 136, Name = "5 tonne 10 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 137, Name = "8 Tonne 2mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 138, Name = "10 Tonne 10 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 139, Name = "17 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 140, Name = "3.2 tonne x  3 mtr x 16 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 141, Name = "10 tonne x 5.5 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 142, Name = "10 tonne x 5 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 143, Name = "10 tonne x 4 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 144, Name = "10 Tonne x 6 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 145, Name = "6.2 Tonne x 3mtr x 22mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 146, Name = "6.2 Tonne x 5 mtr x 22mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 147, Name = "18.5 Tonne x 3 mtr x 38 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 148, Name = "18.5 Tonne x 5 mtr x 38 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 149, Name = "2 tonne 2 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 150, Name = "1.74mtr x 4.24mtr x 1.32mtr - 300kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 151, Name = "400 kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 152, Name = "18.5 Tonne x 8 mtr x 38 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 153, Name = "10 Tonne x 12 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 154, Name = "5.3  Tonne x 15 mtr x 13 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 155, Name = "8 tonne 4 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 156, Name = "85 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 157, Name = "35 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 158, Name = "9.5 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 159, Name = "13.5 tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 160, Name = "10 Tonne x 8 mtr x 28 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 161, Name = "161-İnzibati bina CR-2 və qazanxan HB-1", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 162, Name = "162-Ümumi yük terminalı binaları CR-7 , CR-9 , CR-8", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 163, Name = "163-Texniki xidmət binaları CR-3, CR-4, CR-10, CR-15, CR-16, WS-3", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 164, Name = "164-RO-RO terminalı binaları CR-17, FS-5 , FS-10, FS-11, FS-16, FS-17, FS-18", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 165, Name = "165-BƏRƏ terminalı binaları FS-3, FS-9, FS-12, FS-13, FS-14 , FS-19", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 166, Name = "166-DƏMİRYOLU binaları RM-1, RM-2 ,RM-4 ,RM-5, RM-6, RM- 7, RM-8, RM-13, RM-14, RM15, RM-16", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 167, Name = "167-Mühafizə xidməti binaları AB-1, AB-2, AB-7", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 168, Name = "142 tonne x 3,4 mtr x 56 mm", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 169, Name = "50 Tonne", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 170, Name = "300 kgs", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 171, Name = "4 tonne 2 mtr", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 172, Name = "172-Abşeron Neft Terminalı binaları", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 173, Name = "173-Abşeron Neft Terminalı hidrotexniki qurğuları 1 saylı körpü", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 174, Name = "174-Abşeron Neft Terminalı hidrotexniki qurğuları 3 saylı körpü", IsDeleted = false, IsActive = true },
                    new EquipmentType { Id = 175, Name = "175-Dəniz vağzalı binası", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 176, Name = "176-Dəniz vağzalı hidrotexniki qurğuları", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 177, Name = "177-İdarə binası və mədəniyyət evi", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 178, Name = "178-Qaradağ mülki-müdafiə binaları", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new EquipmentType { Id = 179, Name = "179-Liman ərazisi yollar (Kargo , Ro-Ro , Bərə terminal)", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }

                );
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new Part { Id = 1, Code = "OFL",  Name = "Oil Filter", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 2, Code = "AFL", Name = "Air Filter", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 3, Code = "ENO", Name = "Engine Oil", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 4, Code = "TRN", Name = "TransMission Oil", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 5, Code = "GRB", Name = "Gear_Box Oil", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 6, Code = "WHL", Name = "Wheels", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 7, Code = "ANF", Name = "Antifiriz", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Part { Id = 8, Code = "BRK", Name = "Break pads", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }
                );
            });

            modelBuilder.Entity<MaintenancePlan>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new MaintenancePlan { Id = 1, Code = "POCR-1", Name = "Portal Crane", Description = "Vizual Inspection", MetricType = Metrictype.PERIOD, MetricTypeName = "Period", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new MaintenancePlan { Id = 2, Code = "POCR-2", Name = "Portal Crane Prof", Description = "Profilaktik Inspection", MetricType = Metrictype.MOTO_HOURS, MetricTypeName = "MotoHour", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new MaintenancePlan { Id = 3, Code = "FRKL-1", Name = "Fork Lift", Description = "Vizual Inspection", MetricType = Metrictype.PERIOD, MetricTypeName = "Period", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new MaintenancePlan { Id = 4, Code = "RAIL-1", Name = "Railway", Description = "Vizual Inspection of Railway", MetricType = Metrictype.PERIOD, MetricTypeName = "Period", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new MaintenancePlan { Id = 5, Code = "FRKL-2", Name = "Fork Lift", Description = "Engine Oil Change", MetricType = Metrictype.PERIOD, MetricTypeName = "Period", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }
                );
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new Service { Id = 1, Name = "Engine Oil ", ServiceDescription = "Engine Oil change", ServiceType = "Refill", MaintenancePlanId = 5, IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Service { Id = 2, Name = "Engine Oil Filter", ServiceDescription = "Engine Oil filter change", ServiceType = "Replace", MaintenancePlanId = 5, IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Service { Id = 3, Name = "Engine Oil Change", ServiceDescription = "Engine Oil change", ServiceType = "Refill", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" },
                    new Service { Id = 4, Name = "Engine Oil Change", ServiceDescription = "Engine Oil change", ServiceType = "Refill", IsDeleted = false, IsActive = true, CreatedDate = DateTime.UtcNow, CreatedBy = "System" }
             


                );
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.HasData(
                    new Equipment { Id = 1, Name = "ForkLift-1 ", IsIdle = true, UnitNumber = "FK-100000", Description = "Cargo Handling equipment", Identification = "no", ModelId=14, EquipmentTypeId=1, ManufactureId=10, DepartmentId = 1, OperationSiteid = 4, Status = EquipmentStatus.ACTIVE, usageLocation = Location.GARADAGH, ProductionYear = 1998, CreatedDate = DateTime.UtcNow, Capacity= "2000 ton", CurrentValue = 145,IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl= "forklift.jpeg" },
                    new Equipment { Id = 2, Name = "ForkLift-2", IsIdle = true, UnitNumber = "FK-100001", Description = "Cargo Handling equipment", Identification = "no", ModelId = 13, EquipmentTypeId = 2, ManufactureId = 9, DepartmentId = 1, OperationSiteid = 3, Status = EquipmentStatus.ACTIVE, usageLocation = Location.GARADAGH, ProductionYear = 2004, CreatedDate = DateTime.UtcNow, Capacity = "4000 ton", CurrentValue = 450, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 3, Name = "Crane-3 ", IsIdle = true, UnitNumber = "CR-100003", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 3, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2003, CreatedDate = DateTime.UtcNow, Capacity = "40000 ton", CurrentValue = 500, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 4, Name = "Buldozer-4 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 5, Name = "Buldozer-5 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 6, Name = "Buldozer-6 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 7, Name = "ReachStacker-7", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 8, Name = "ReachStacker-8", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 9, Name = "ReachStacker-9", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 10, Name = "ReachStacker-10", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 11, Name = "Truck-11", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 12, Name = "Truck-12", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 13, Name = "Truck-13", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 14, Name = "Truck-14", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 15, Name = "Platform-15", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 16, Name = "MiniBus-16", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 17, Name = "Minibus-17", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 6, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 18, Name = "Tractor-18", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 6, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 19, Name = "Tractor-19", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 6, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 20, Name = "Spreider-20", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 21, Name = "Building001-21", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 22, Name = "Building002-22", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 23, Name = "Building003-23", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 24, Name = "Car-24", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 5, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 25, Name = "Car-25", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 5, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 26, Name = "Car-26", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 5, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 27, Name = "Station-27", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 28, Name = "Station-28", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 29, Name = "ElectroCar-29", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 30, Name = "ElectroCar-30", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 5, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 31, Name = "ElectroCar-31", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 32, Name = "ElectroCar-32", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 33, Name = "ElectroCar-33", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 5, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 34, Name = "ElectroCar-34", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 6, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 35, Name = "ElectroCar-35", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 6, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 36, Name = "Crane-36", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 37, Name = "Crane-37", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 38, Name = "Crane-38", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 39, Name = "Crane-39", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 40, Name = "Crane-40", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },

                    new Equipment { Id = 41, Name = "ForkLift-41 ", IsIdle = true, UnitNumber = "FK-100000", Description = "Cargo Handling equipment", Identification = "no", ModelId = 14, EquipmentTypeId = 1, ManufactureId = 10, DepartmentId = 7, OperationSiteid = 4, Status = EquipmentStatus.ACTIVE, usageLocation = Location.GARADAGH, ProductionYear = 1998, CreatedDate = DateTime.UtcNow, Capacity = "2000 ton", CurrentValue = 145, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 42, Name = "ForkLift-42", IsIdle = true, UnitNumber = "FK-100001", Description = "Cargo Handling equipment", Identification = "no", ModelId = 13, EquipmentTypeId = 2, ManufactureId = 9, DepartmentId = 7, OperationSiteid = 3, Status = EquipmentStatus.ACTIVE, usageLocation = Location.GARADAGH, ProductionYear = 2004, CreatedDate = DateTime.UtcNow, Capacity = "4000 ton", CurrentValue = 450, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 43, Name = "Crane-43 ", IsIdle = true, UnitNumber = "CR-100003", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 7, OperationSiteid = 3, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2003, CreatedDate = DateTime.UtcNow, Capacity = "40000 ton", CurrentValue = 500, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 44, Name = "Buldozer-44 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 45, Name = "Buldozer-45 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 46, Name = "Buldozer-46 ", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 47, Name = "ReachStacker-47", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 48, Name = "ReachStacker-48", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 49, Name = "ReachStacker-49", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 8, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 50, Name = "ReachStacker-50", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 51, Name = "Truck-51", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 52, Name = "Truck-52", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 53, Name = "Truck-53", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 54, Name = "Truck-54", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 55, Name = "Platform-55", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 9, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 56, Name = "MiniBus-56", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 57, Name = "Minibus-57", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 58, Name = "Tractor-58", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 59, Name = "Tractor-59", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 60, Name = "Spreider-60", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 61, Name = "Building001-61", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 62, Name = "Building002-62", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 63, Name = "Building003-63", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 10, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 64, Name = "Car-64", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 65, Name = "Car-65", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 66, Name = "Car-66", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 1, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 67, Name = "Station-67", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 68, Name = "Station-68", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 3, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 69, Name = "ElectroCar-69", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 70, Name = "ElectroCar-70", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 71, Name = "ElectroCar-71", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 72, Name = "ElectroCar-72", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 2, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 73, Name = "ElectroCar-73", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 74, Name = "ElectroCar-74", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 75, Name = "ElectroCar-75", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 76, Name = "Crane-76", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 77, Name = "Crane-77", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 78, Name = "Crane-78", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 79, Name = "Crane-79", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 11, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" },
                    new Equipment { Id = 80, Name = "Crane-80", IsIdle = true, UnitNumber = "CR-100004", Description = "Cargo Lifting equipment", Identification = "no", ModelId = 17, EquipmentTypeId = 4, ManufactureId = 4, DepartmentId = 4, OperationSiteid = 6, Status = EquipmentStatus.ACTIVE, usageLocation = Location.SUMGAYIT, ProductionYear = 2010, CreatedDate = DateTime.UtcNow, Capacity = "80000 ton", CurrentValue = 320, IsDeleted = false, IsActive = true, CreatedBy = "System", MpCompleted = true, ImagUrl = "forklift.jpeg" }
                );
            });

        }

    }
}
