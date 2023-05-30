﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs
{
    public class PurchaseDTO
    {
        public string CodErp { get; set; }
        public string Document { get; set; }
        public int Id { get; set; } 
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
