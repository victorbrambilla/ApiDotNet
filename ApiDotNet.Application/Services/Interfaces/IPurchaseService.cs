using ApiDotNet.Application.DTOs;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IPurchaseService
    {
        Task<ResultService<PurchaseDTO>> CreateAsync(PurchaseDTO purchase);

        Task<ResultService<ICollection<PurchaseDetailDTO>>> GetAllAsync();

        Task<ResultService<PurchaseDetailDTO>> GetByIdAsync(int id);

        Task<ResultService> UpdateAsync(PurchaseDTO purchase);

        Task<ResultService> DeleteAsync(int id);

        Task<ResultService<ICollection<PurchaseDetailDTO>>> GetByPersonIdAsync(int personId);

        Task<ResultService<ICollection<PurchaseDetailDTO>>> GetByProductIdAsync(int productId);
    }
}