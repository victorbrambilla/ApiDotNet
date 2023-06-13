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
using ApiDotNet.Infra.Data.Common;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class UserPermissionRepository : BaseRepository<UserPermission>, IUserPermissionRepository

    {
        public UserPermissionRepository(ApplicationDbContext db) : base(db)
        {
        }

        public override async Task<ICollection<UserPermission>> GetAllAsync()
        {
            return await _db.UserPermissions
                .Include(x => x.Permission)
                .Include(x => x.User)
                .ToListAsync();
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