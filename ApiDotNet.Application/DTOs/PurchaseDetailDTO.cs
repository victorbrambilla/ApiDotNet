﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs
{
    public class PurchaseDetailDTO
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Product { get; set; }
        public DateTime DateTime { get; set; }
    }
}