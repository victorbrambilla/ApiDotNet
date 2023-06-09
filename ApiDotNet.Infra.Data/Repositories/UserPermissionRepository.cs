using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class UserPermissionRepository : IUserPermissionRepository

    {
        private readonly ApplicationDbContext _db;

        public UserPermissionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task DeletePermissionAsync(UserPermission userPermission)
        {
            _db.Remove(userPermission);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<UserPermission>> GetAllAsync()
        {
            return await _db.UserPermissions
                .Include(x => x.Permission)
                .Include(x => x.User)
                .ToListAsync();
        }

        public async Task<UserPermission> GetByIdAsync(int id)
        {
            return await _db.UserPermissions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<UserPermission>> GetByUserId(int id)
        {
            return await _db.UserPermissions
                .Include(x => x.Permission)
                .Include(x => x.User)
                .Where(x => x.UserId == id)
                .ToListAsync();
        }
    }
}