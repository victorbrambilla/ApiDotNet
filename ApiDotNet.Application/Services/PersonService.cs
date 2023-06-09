﻿using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.FiltersDb;
using ApiDotNet.Domain.Repositories;
using AutoMapper;

namespace ApiDotNet.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IUserRepository _userRepository;

        public PersonService(IPersonRepository personRepository, IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _userRepository = userRepository;
        }

        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            if (personDTO == null)
            {
                return ResultService.Fail<PersonDTO>("Objeto deve ser informado");
            }

            var result = new PersonDTOValidator().Validate(personDTO);
            if (!result.IsValid)
            {
                return ResultService.RequestError<PersonDTO>("Problemas de validação!", result);
            }

            var user = await _userRepository.GetUserByIdAsync(personDTO.UserId);
            if (user == null)
            {
                return ResultService.Fail<PersonDTO>("Usuário não encontrado");
            }

            var person = _mapper.Map<Person>(personDTO);
            var data = await _personRepository.CreateAsync(person);
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var data = await _personRepository.GetAsync(id);
            if (data == null)
            {
                return ResultService.Fail("Pessoa não encontrada");
            }
            await _personRepository.DeleteAsync(data);
            return ResultService.Ok("Pessoa deletada");
        }

        public async Task<ResultService<ICollection<PersonDTO>>> GetAllAsync()
        {
            var data = await _personRepository.GetAllAsync();
            return ResultService.Ok<ICollection<PersonDTO>>(_mapper.Map<ICollection<PersonDTO>>(data));
        }

        public async Task<ResultService<PersonDTO>> GetByIdAsync(int id)
        {
            var data = await _personRepository.GetAsync(id);
            if (data == null)
            {
                return ResultService.Fail<PersonDTO>("Pessoa não encontrada");
            }

            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }

        public async Task<ResultService<PagedBaseResponseDTO<PersonDTO>>> GetPagedAsync(PersonFilterDb personFilterDb)
        {
            var peoplePaged = await _personRepository.GetPagedAsync(personFilterDb);
            var result = new PagedBaseResponseDTO<PersonDTO>(peoplePaged.TotalRegisters, _mapper.Map<List<PersonDTO>>(peoplePaged.Result));
            return ResultService.Ok(result);
        }

        public async Task<ResultService> UpdateAsync(PersonDTO personDTO)
        {
            if (personDTO == null)
            {
                return ResultService.Fail("Objeto deve ser informado");
            }

            var result = new PersonDTOValidator().Validate(personDTO);
            if (!result.IsValid)
            {
                return ResultService.RequestError("Problemas de validação!", result);
            }

            var person = await _personRepository.GetAsync(personDTO.Id);
            if (person == null)
            {
                return ResultService.Fail("Pessoa não encontrada");
            }

            person = _mapper.Map<PersonDTO, Person>(personDTO, person);
            await _personRepository.UpdateAsync(person);
            return ResultService.Ok("Pessoa atualizada");
        }
    }
}