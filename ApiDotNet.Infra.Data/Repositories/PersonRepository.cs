using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.FiltersDb;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Common;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<int> GetIdByDocumentAsync(string document)
        {
            return (await _db.People.FirstOrDefaultAsync(x => x.Document == document))?.Id ?? 0;
        }

        public async Task<PagedBaseResponse<Person>> GetPagedAsync(PersonFilterDb request)
        {
            var people = _db.People.AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
                people = people.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));

            return await PagedBaseResponseHelper.GetResponseAsync<PagedBaseResponse<Person>, Person>(people, request);
        }

        public async Task<ICollection<Person>> GetPeopleAsync()
        {
            return await _db.People.ToListAsync();
        }
    }
}