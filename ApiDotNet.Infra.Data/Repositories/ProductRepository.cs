using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {   
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) {
            _db = db;
        }

        public async Task<Product> createAsync(Product product)
        {
            _db.Add(product);
           await _db.SaveChangesAsync();
            return product;
        }

        public async Task deleteAsync(Product product)
        {
            _db.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task<Product> getByIdAsync(int id)
        {
            return await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Product>> getProductsAsync()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task updateAsync(Product product)
        {
              _db.Update(product);
            await _db.SaveChangesAsync();
        }
    }
}
