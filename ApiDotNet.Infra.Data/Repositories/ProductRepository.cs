using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Common;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<int> GetIdByCodErpAsync(string codErp)
        {
            return (await _db.Products.FirstOrDefaultAsync(x => x.CodErp == codErp))?.Id ?? 0;
        }
    }
}