using ApiDotNet.Application.DTOs;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO person);

        Task<ResultService<ICollection<PersonDTO>>> GetAllAsync();

        Task<ResultService<PersonDTO>> GetByIdAsync(int id);

        Task<ResultService> UpdateAsync(PersonDTO person);

        Task<ResultService> DeleteAsync(int id);
    }
}