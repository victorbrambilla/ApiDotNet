using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDotNet.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public bool ValidateUserPermissions(List<string> permissionsUser, List<string> permissionNeeded)
        {
            return permissionNeeded.Any(x => permissionsUser.Contains(x));
        }

        [NonAction]
        public IActionResult Forbidden()
        {
            var obj = new
            {
                code = "permissão_negada",
                message = "Você não tem permissão para acessar este recurso"
            };

            return new ObjectResult(obj) { StatusCode = 403 };
        }
    }
}