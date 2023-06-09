using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ApiDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : BaseController
    {
        private readonly IPermissionService _permissionService;
        private readonly ICurrentUser _currentUser;
        private List<string> _permissionsNeeded = new List<string>() { "Admin" };
        private readonly List<string> _permissionsUser;

        public PermissionController(IPermissionService permissionService, ICurrentUser currentUser)
        {
            _permissionService = permissionService;
            _currentUser = currentUser;
            _permissionsUser = _currentUser.Permissions?.Split(",").ToList() ?? new List<string>();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PermissionDTO permissionDTO)
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _permissionService.CreateAsync(permissionDTO);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _permissionService.GetAllAsync();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _permissionService.GetByIdAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] PermissionDTO permissionDTO)
        {
            if (!ValidateUserPermissions(_permissionsUser, _permissionsNeeded))
            {
                return Forbidden();
            }
            var result = await _permissionService.UpdateAsync(permissionDTO);
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
            var result = await _permissionService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}