using ApiDotNet.Domain.Repositories;

namespace ApiDotNet.Domain.FiltersDb
{
    public class PersonFilterDb : PagedBaseRequest
    {
        public string? Name { get; set; }
    }
}