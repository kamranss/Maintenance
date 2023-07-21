using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class MaintenanceDbContext:DbContext
    {
        public MaintenanceDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
