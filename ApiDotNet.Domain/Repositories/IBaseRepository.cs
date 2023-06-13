using ApiDotNet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T?> GetAsync(int id);

        Task<ICollection<T>> GetAllAsync();
    }
}