using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Authentication;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using AutoMapper;

namespace ApiDotNet.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IHashing _hashing;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, ITokenGenerator tokenGenerator, IMapper mapper, IHashing hashing)
        {
            this._userRepository = userRepository;
            this._tokenGenerator = tokenGenerator;
            this._mapper = mapper;
            _hashing = hashing;
        }

        public async Task<ResultService<UserDTO>> CreateUserAsync(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return ResultService.Fail<UserDTO>("Usuário não informado!");
            }

            var validate = new UserDTOValidator().Validate(userDTO);
            if (!validate.IsValid)
            {
                return ResultService.RequestError<UserDTO>("Problemas de validação ", validate);
            }

            var user = await _userRepository.GetUserByEmailAsync(userDTO.Email);
            if (user != null)
            {
                return ResultService.Fail<UserDTO>("Usuário já cadastrado!");
            }

            userDTO.Password = _hashing.UseArgon2(userDTO.Password);
            var userCreated = _mapper.Map<User>(userDTO);

            var data = await _userRepository.CreateUser(userCreated);
            return ResultService.Ok<UserDTO>(_mapper.Map<UserDTO>(data));
        }

        public async Task<ResultService<dynamic>> GenerateTokenAsync(UserDTO userDTO)
        {
            if (userDTO == null)
                return ResultService.Fail<dynamic>("Usuário não informado!");

            var validate = new UserDTOValidator().Validate(userDTO);
            if (!validate.IsValid)
                return ResultService.RequestError<dynamic>("Problemas de validação ", validate);

            var user = await _userRepository.GetUserByEmailAsync(userDTO.Email);
            if (user == null)
                return ResultService.Fail<dynamic>("Usuário não encontrado!");

            var verifyPassword = _hashing.VerifyArgon2(user.Password, userDTO.Password);
            if (!verifyPassword)
                return ResultService.Fail<dynamic>("Senha inválida!");


            return ResultService.Ok<dynamic>(_tokenGenerator.Generator(user));
        }
    }
}