using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Post([FromBody] UserDTO userDTO)
        {
            var result = await _userService.GenerateTokenAsync(userDTO);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> PostRegister([FromBody] UserDTO userDTO)
        {
            var result = await _userService.CreateUserAsync(userDTO);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}