using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Common;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}