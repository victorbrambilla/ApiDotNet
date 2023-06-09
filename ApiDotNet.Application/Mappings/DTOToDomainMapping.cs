using ApiDotNet.Application.DTOs;
using ApiDotNet.Domain.Entities;
using AutoMapper;

namespace ApiDotNet.Application.Mappings
{
    public class DTOToDomainMapping : Profile
    {
        public DTOToDomainMapping()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<ProductDTO, Product>();
            CreateMap<PurchaseDTO, Purchase>();
            CreateMap<UserDTO, User>();
            CreateMap<PermissionDTO, Permission>();
        }
    }
}