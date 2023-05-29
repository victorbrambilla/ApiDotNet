using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Repositories
{
    public class PagedBaseResponse<T>
    {
        public List<T> Result { get; set; }
        public int TotalPages { get; set; }
        public int TotalRegisters { get; set; }

    }
}
