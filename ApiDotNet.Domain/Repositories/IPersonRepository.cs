using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.FiltersDb;

namespace ApiDotNet.Domain.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        Task<int> GetIdByDocumentAsync(string document);

        Task<PagedBaseResponse<Person>> GetPagedAsync(PersonFilterDb request);
    }
}