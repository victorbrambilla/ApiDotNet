using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.FiltersDb;

namespace ApiDotNet.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);

        Task<ICollection<Person>> GetPeopleAsync();

        Task<Person> CreateAsync(Person person);

        Task UpdateAsync(Person person);

        Task DeleteAsync(Person person);

        Task<int> GetIdByDocumentAsync(string document);

        Task<PagedBaseResponse<Person>> GetPagedAsync(PersonFilterDb request);
    }
}