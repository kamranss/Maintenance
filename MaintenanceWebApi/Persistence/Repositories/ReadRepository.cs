using Application.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{

    public class ReadRepository<T>:IReadRepository<T> where T : BaseEntity
    {

        
        public DbSet<T> Table { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        readonly private MaintenanceDbContext _maintenanceDbContext;
        public ReadRepository(MaintenanceDbContext context )
        {
            _maintenanceDbContext = context;
            Table = _maintenanceDbContext.Set<T>();
        }

        public IQueryable<T> GetAll(bool tracking = true)
        {
            return Table;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            return Table.Where(method);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            return await Table.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            return await Table.FirstOrDefaultAsync(i => i.Id == Guid.Parse(id));
        }
        //public DbSet<T> Table => _context.Set<T>();


    }
}
