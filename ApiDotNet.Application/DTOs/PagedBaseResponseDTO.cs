using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs
{
    public class PagedBaseResponseDTO<T>
    {
        public PagedBaseResponseDTO(int totalRegisters, List<T> resuts)
        {
            TotalRegisters = totalRegisters;
            Resuts = resuts;
        }

        public int TotalRegisters { get; set; }
        public  List<T> Resuts { get; set; }

       
    }
}
