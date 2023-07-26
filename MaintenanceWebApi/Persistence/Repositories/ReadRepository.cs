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

    public class ReadRepository<T> : IReadRepository<T> where T: class
    {

        readonly private MaintenanceDbContext _context;
        public ReadRepository(MaintenanceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        DbSet<T> IRepository<T>.Table { set => _context.Set<T>(); }

        public IQueryable<T> GetAll(bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        //public DbSet<T> Table => _context.Set<T>();

    }
}
