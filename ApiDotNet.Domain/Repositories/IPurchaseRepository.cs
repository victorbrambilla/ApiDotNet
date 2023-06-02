using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IPurchaseRepository
    {
        Task<Purchase> GetByIdAsync(int id);

        Task<ICollection<Purchase>> GetAllAsync();

        Task<Purchase> CreateAsync(Purchase purchase);

        Task UpdateAsync(Purchase purchase);

        Task DeleteAsync(Purchase purchase);

        Task<ICollection<Purchase>> GetByPersonIdAsync(int personId);

        Task<ICollection<Purchase>> GetByProductIdAsync(int productId);
    }
}