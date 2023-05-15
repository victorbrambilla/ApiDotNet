using ApiDotNet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO person);

        Task<ResultService<ICollection<PersonDTO>>> GetAllAsync();
        Task<ResultService<PersonDTO>> GetByIdAsync(int id);
    }
}
