using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> CreateUser(User user);

        Task<User> GetUserByIdAsync(int id);
    }
}