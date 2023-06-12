using ApiDotNet.Domain.Common;
using ApiDotNet.Domain.Validation;

namespace ApiDotNet.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int? PersonId { get; private set; }
        public Person? Person { get; private set; }

        public User(string email, string password)
        {
            Validation(email, password);
            UserPermissions = new List<UserPermission>();
        }

        public User(int id, string email, string password)
        {
            DomainValidationException.When(id < 0, "Id deve ser informado");
            Id = id;
            Validation(email, password);
            UserPermissions = new List<UserPermission>();
        }

        public ICollection<UserPermission> UserPermissions { get; set; }

        private void Validation(string email, string password)
        {
            DomainValidationException.When(string.IsNullOrEmpty(email), "Email deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(password), "Senha deve ser informado");

            Email = email;
            Password = password;
        }
    }
}