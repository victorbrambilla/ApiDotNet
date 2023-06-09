using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly ApplicationDbContext _db;

        public PermissionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Permission> CreatePermissionAsync(Permission permission)
        {
            _db.Add(permission);
            await _db.SaveChangesAsync();
            return permission;
        }

        public async Task DeletePermissionAsync(Permission permission)
        {
            _db.Remove(permission);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Permission>> GetAllPermissionsAsync()
        {
            return await _db.Permissions.ToListAsync();
        }

        public async Task<Permission> GetByIdAsync(int id)
        {
            return await _db.Permissions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Permission> UpdatePermissionAsync(Permission permission)
        {
            _db.Update(permission);

            await _db.SaveChangesAsync();
            return permission;
        }
    }
}