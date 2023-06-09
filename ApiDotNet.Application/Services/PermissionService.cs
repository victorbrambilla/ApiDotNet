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
    public class PermissionService : IPermissionService
    {
        private readonly IMapper _mapper;
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IMapper mapper, IPermissionRepository permissionRepository)
        {
            _mapper = mapper;
            _permissionRepository = permissionRepository;
        }

        public async Task<ResultService<PermissionDTO>> CreateAsync(PermissionDTO permissionDTO)
        {
            if (permissionDTO == null)
            {
                return ResultService.Fail<PermissionDTO>("Objeto deve ser informado");
            }
            var validate = new PermissionDTOValidator().Validate(permissionDTO);
            if (!validate.IsValid)
            {
                return ResultService.RequestError<PermissionDTO>("Problemas de validação!", validate);
            }
            var permission = _mapper.Map<Permission>(permissionDTO);
            var data = await _permissionRepository.CreatePermissionAsync(permission);
            return ResultService.Ok<PermissionDTO>(_mapper.Map<PermissionDTO>(data));
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var data = await _permissionRepository.GetByIdAsync(id);
            if (data == null)
            {
                return ResultService.Fail("Permissão não encontrada");
            }
            await _permissionRepository.DeletePermissionAsync(data);
            return ResultService.Ok("Permissão deletada");
        }

        public async Task<ResultService<ICollection<PermissionDTO>>> GetAllAsync()
        {
            var data = await _permissionRepository.GetAllPermissionsAsync();
            return ResultService.Ok<ICollection<PermissionDTO>>(_mapper.Map<ICollection<PermissionDTO>>(data));
        }

        public async Task<ResultService<PermissionDTO>> GetByIdAsync(int id)
        {
            var data = await _permissionRepository.GetByIdAsync(id);
            if (data == null)
            {
                return ResultService.Fail<PermissionDTO>("Permissão não encontrada");
            }
            return ResultService.Ok<PermissionDTO>(_mapper.Map<PermissionDTO>(data));
        }

        public async Task<ResultService> UpdateAsync(PermissionDTO permissionDTO)
        {
            if (permissionDTO == null)
            {
                return ResultService.Fail("Objeto deve ser informado");
            }
            var validate = new PermissionDTOValidator().Validate(permissionDTO);
            if (!validate.IsValid)
            {
                return ResultService.RequestError("Problemas de validação!", validate);
            }

            var data = await _permissionRepository.GetByIdAsync(permissionDTO.Id);
            if (data == null)
            {
                return ResultService.Fail("Permissão não encontrada");
            }

            var permission = _mapper.Map<PermissionDTO, Permission>(permissionDTO, data);
            await _permissionRepository.UpdatePermissionAsync(permission);
            return ResultService.Ok("Permissão atualizada");
        }
    }
}