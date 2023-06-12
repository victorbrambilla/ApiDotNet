using ApiDotNet.Domain.Common;
using ApiDotNet.Domain.Validation;

namespace ApiDotNet.Domain.Entities
{
    public sealed class Person : BaseEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public int UserId { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public User User { get; private set; }

        public Person(string document, string name, string phone, int userId)
        {
            Validation(document, name, phone, userId);
            Purchases = new List<Purchase>();
        }

        public Person(int id, string document, string name, string phone, int userId)
        {
            DomainValidationException.When(id < 0, "Id inválido");
            Id = id;
            Validation(document, name, phone, userId);
            Purchases = new List<Purchase>();
        }

        private void Validation(string document, string name, string phone, int userId)
        {
            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Celular deve ser informado!");
            DomainValidationException.When(userId <= 0, "Usuário deve ser informado!");

            Name = name;
            Phone = phone;
            Document = document;
            UserId = userId;
        }
    }
}