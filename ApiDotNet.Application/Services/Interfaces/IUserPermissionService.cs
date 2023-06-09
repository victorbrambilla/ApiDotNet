using ApiDotNet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services.Interfaces
{
    public interface IUserPermissionService
    {
        Task<ResultService<ICollection<UserPermissionDTO>>> GetAllAsync();

        Task<ResultService<ICollection<UserPermissionDTO>>> GetByUserIdAsync(int id);

        Task<ResultService> DeleteAsync(int id);
    }
}