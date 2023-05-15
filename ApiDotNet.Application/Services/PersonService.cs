using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }
        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            if(personDTO == null)
            {
                return  ResultService.Fail<PersonDTO>("Objeto deve ser informado");
            }

            var result = new PersonDTOValidator().Validate(personDTO);
            if(!result.IsValid)
            {
                return ResultService.RequestError<PersonDTO>("Problemas de validação!", result);
            }

            var person = _mapper.Map<Person>(personDTO);
            var data = await _personRepository.CreateAsync(person);
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));  
        }

        public async Task<ResultService<ICollection<PersonDTO>>> GetAllAsync()
        {
            var data = await _personRepository.GetPeopleAsync();
            return ResultService.Ok<ICollection<PersonDTO>>(_mapper.Map<ICollection<PersonDTO>>(data));
        }

        public async Task<ResultService<PersonDTO>> GetByIdAsync(int id)
        {
          var data = await _personRepository.GetByIdAsync(id);
            if(data == null)
            {
                return ResultService.Fail<PersonDTO>("Pessoa não encontrada");
            }
    
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }
    }
}
