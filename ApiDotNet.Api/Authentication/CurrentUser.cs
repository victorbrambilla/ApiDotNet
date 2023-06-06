using ApiDotNet.Domain.Authentication;

namespace ApiDotNet.Api.Authentication
{
    public class CurrentUser : ICurrentUser
    {
        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            var httpContext = httpContextAccessor.HttpContext;
            var claims = httpContext.User.Claims;

            if (claims.Any(x => x.Type == "Id"))
            {
                var id = Convert.ToInt32(claims.First(x => x.Type == "Id").Value);
                Id = id;
            }

            if (claims.Any(x => x.Type == "Email"))
            {
                var email = claims.First(x => x.Type == "Email").Value;
                Email = email;
            }

            if (claims.Any(x => x.Type == "Permissions"))
            {
                var permissions = claims.First(x => x.Type == "Permissions").Value;
                Permissions = permissions;
            }
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Permissions { get; set; }
    }
}