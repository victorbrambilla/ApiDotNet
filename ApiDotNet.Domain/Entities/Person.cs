﻿using ApiDotNet.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Entities
{
        public sealed class Person
        {
            public int Id { get; private set; }
            public string Name { get; private set; }
            public string Document {get; private set; }
            public string Phone { get; private set; }
            public ICollection<Purchase> Purchase { get; set; }
            public Person(string document, string name, string phone) 
            {
                   Validation(document, name, phone); 
                          
            }

            public Person(int id, string document, string name, string phone)
            {
                DomainValidationException.When(id < 0, "Id inválido");
                Id = id;
                Validation(document, name, phone);

            }
            private void Validation(string document, string name, string phone)
            {
                DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado!");
                DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
                DomainValidationException.When(string.IsNullOrEmpty(phone), "Celular deve ser informado!");

                Name = name;
                Phone = phone;
                Document = document;
            }
        }
}
