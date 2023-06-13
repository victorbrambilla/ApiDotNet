using ApiDotNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Repositories
{
    public interface IUserPermissionRepository : IBaseRepository<UserPermission>
    {
        new Task<ICollection<UserPermission>> GetAllAsync();

        Task<ICollection<UserPermission>> GetByUserId(int id);
    }
}