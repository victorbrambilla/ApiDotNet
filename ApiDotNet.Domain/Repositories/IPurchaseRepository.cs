using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IPurchaseRepository : IBaseRepository<Purchase>
    {
        Task<Purchase> GetByIdAsync(int id);

        new Task<ICollection<Purchase>> GetAllAsync();

        Task<ICollection<Purchase>> GetByPersonIdAsync(int personId);

        Task<ICollection<Purchase>> GetByProductIdAsync(int productId);
    }
}