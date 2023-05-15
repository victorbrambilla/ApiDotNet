using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDTO personDTO)
        {
            var result = await _personService.CreateAsync(personDTO);
            if(result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await _personService.GetAllAsync();
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await _personService.GetByIdAsync(id);
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
