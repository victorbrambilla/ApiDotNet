using ApiDotNet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO);
        Task<ResultService<ProductDTO>> UpdateAsync(ProductDTO productDTO);
        Task<ResultService<ProductDTO>> DeleteAsync(int id);
        Task<ResultService<ProductDTO>> GetByIdAsync(int id);
        Task<ResultService<IEnumerable<ProductDTO>>> GetAllAsync();
    }
}
