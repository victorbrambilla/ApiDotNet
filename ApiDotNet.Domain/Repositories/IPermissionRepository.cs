using ApiDotNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Repositories
{
    public interface IPermissionRepository
    {
        Task<ICollection<Permission>> GetAllPermissionsAsync();

        Task<Permission> CreatePermissionAsync(Permission permission);

        Task<Permission> GetByIdAsync(int id);

        Task<Permission> UpdatePermissionAsync(
            Permission permission);

        Task DeletePermissionAsync(Permission permission);
    }
}