using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Common;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _db.Users
                .Include(u => u.UserPermissions).ThenInclude(u => u.Permission)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _db.Users
                .Include(u => u.UserPermissions).ThenInclude(u => u.Permission)
                .Include(u => u.Person)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}