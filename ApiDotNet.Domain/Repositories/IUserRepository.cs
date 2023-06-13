using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetUserByEmailAsync(string email);

        Task<User?> GetUserByIdAsync(int id);
    }
}