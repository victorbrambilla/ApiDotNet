using ApiDotNet.Domain.Common;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Common
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<T?> CreateAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            entity.IsDeleted = true;
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}