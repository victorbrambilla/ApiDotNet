using ApiDotNet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<ResultService<ICollection<PermissionDTO>>> GetAllAsync();

        Task<ResultService<PermissionDTO>> GetByIdAsync(int id);

        Task<ResultService<PermissionDTO>> CreateAsync(PermissionDTO permission);

        Task<ResultService> UpdateAsync(PermissionDTO permission);

        Task<ResultService> DeleteAsync(int id);
    }
}