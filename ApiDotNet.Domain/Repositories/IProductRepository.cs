using ApiDotNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> getByIdAsync(int id);
        Task<ICollection<Product>> getProductsAsync();
        Task<Product> createAsync(Product product);
        Task updateAsync(Product product);
        Task deleteAsync(Product product);

    }
}
