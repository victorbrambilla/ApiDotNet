using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Domain.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<int> GetIdByCodErpAsync(string codErp);
    }
}