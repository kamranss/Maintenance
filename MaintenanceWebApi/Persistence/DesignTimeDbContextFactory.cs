using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistence.Configuration;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MaintenanceDbContext>
    {
        MaintenanceDbContext IDesignTimeDbContextFactory<MaintenanceDbContext>.CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MaintenanceDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(DbConfiguration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }

    }
}
