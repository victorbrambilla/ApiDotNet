using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Authentication;
using Microsoft.AspNetCore.Mvc;

using ApiDotNet.Application.DTOs;

using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ApiDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPermissionController : BaseController
    {
        private readonly IUserPermissionService _userPermissionService;
        private readonly ICurrentUser _currentUser;
        private List<string> _permissionsNeeded = new List<string>() { "Admin" };
        private readonly List<string> _permissionsUser;

        public UserPermissionController(IUserPermissionService userPermissionService, ICurrentUser currentUser)
        {
            _userPermissionService = userPermissionService;
            _currentUser = currentUser;
            _permissionsUser = _currentUser.Permissions?.Split(",").ToList() ?? new List<string>();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _userPermissionService.GetAllAsync();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByIdAsync(int userId)
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _userPermissionService.GetByUserIdAsync(userId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _userPermissionService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}