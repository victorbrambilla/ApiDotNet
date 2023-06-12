﻿using ApiDotNet.Domain.Common;
using ApiDotNet.Domain.Validation;

namespace ApiDotNet.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Product(string name, string codErp, decimal price)
        {
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
        }

        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(id < 0, "O Id deve ser informado");
            Id = id;
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
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