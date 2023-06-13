using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services
{
    public class UserPermissionService : IUserPermissionService
    {
        private readonly IMapper _mapper;
        private readonly IUserPermissionRepository _userPermissionRepository;

        public UserPermissionService(IMapper mapper, IUserPermissionRepository userPermissionRepository)
        {
            _mapper = mapper;
            _userPermissionRepository = userPermissionRepository;
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var data = await _userPermissionRepository.GetAsync(id);
            if (data == null)
            {
                return ResultService.Fail("Permissão não encontrada");
            }
            await _userPermissionRepository.DeleteAsync(data);
            return ResultService.Ok("Permissão deletada");
        }

        public async Task<ResultService<ICollection<UserPermissionDTO>>> GetAllAsync()
        {
            var data = await _userPermissionRepository.GetAllAsync();
            return ResultService.Ok<ICollection<UserPermissionDTO>>(_mapper.Map<ICollection<UserPermissionDTO>>(data));
        }

        public async Task<ResultService<ICollection<UserPermissionDTO>>> GetByUserIdAsync(int id)
        {
            var data = await _userPermissionRepository.GetByUserId(id);
            return ResultService.Ok<ICollection<UserPermissionDTO>>(_mapper.Map<ICollection<UserPermissionDTO>>(data));
        }
    }
}