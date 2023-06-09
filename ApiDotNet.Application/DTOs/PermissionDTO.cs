using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs
{
    public class PermissionDTO
    {
        public int Id { get; set; }
        public string VisualName { get; set; }
        public string PermissionName { get; set; }
    }
}