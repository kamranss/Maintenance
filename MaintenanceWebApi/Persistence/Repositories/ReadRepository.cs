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

        public DbSet<T> Table { get; set; }
        readonly private MaintenanceDbContext _maintenanceDbContext;
        public ReadRepository(MaintenanceDbContext context )
        {
            this._maintenanceDbContext = context;
            this.Table = _maintenanceDbContext.Set<T>();
        }

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
            {
                query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
            //return await Table.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            //return await Table.FirstOrDefaultAsync(i => i.Id == Guid.Parse(id));
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(i => i.Id == id);
        }




        //public DbSet<T> Table => _table;





    }
}
//public DbSet<T> Table => _context.Set<T>();