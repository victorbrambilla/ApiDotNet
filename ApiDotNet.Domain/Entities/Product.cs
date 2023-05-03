﻿using ApiDotNet.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchase { get; set; }

        public Product(string name, string codErp, decimal price) 
        { 
            Validation(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(id < 0, "O Id deve ser informado");
            Id = id;
            Validation(name, codErp, price);
        }

        private void Validation(string name, string codeErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codeErp), "Código erp deve ser informado");
            DomainValidationException.When(price < 0, "Preço deve ser informado");

            Name = name;
            CodErp = codeErp;
            Price = price;
        }
    }
}
