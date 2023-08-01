using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddListAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveList(List<T> datas);
        Task<bool> RemoveAsync(int id);
        bool Update(T model);

        Task<int> SaveAsync();
    }
}
