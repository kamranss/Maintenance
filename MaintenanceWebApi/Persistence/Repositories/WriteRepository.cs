using Application.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private readonly MaintenanceDbContext _maintenanceDbContext;

        public WriteRepository(MaintenanceDbContext maintenanceDbContext)
        {
            _maintenanceDbContext = maintenanceDbContext;
            Table = _maintenanceDbContext.Set<T>();
        }

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry=  await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddListAsync(List<T> datas)
        {
           await Table.AddRangeAsync(datas);
           return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry =  Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveList(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            //EntityEntry<T> entityEntry = await Table.FirstOrDefaultAsync(i=> i.Id == Guid.Parse(id));
            //return entityEntry.State == EntityState.Deletedl

        }

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
