using ApiDotNet.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.FiltersDb
{
    public class PersonFilterDb :PagedBaseRequest
    {
        public string? Name { get; set; }
    }
}
