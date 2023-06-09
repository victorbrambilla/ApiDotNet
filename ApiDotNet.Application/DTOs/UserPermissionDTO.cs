using ApiDotNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs
{
    public class UserPermissionDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }
    }
}