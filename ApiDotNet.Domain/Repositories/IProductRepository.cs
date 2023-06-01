using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);

        Task<ICollection<Product>> GetProductsAsync();

        Task<Product> CreateAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);

        Task<int> GetIdByCodErpAsync(string codErp);
    }
}