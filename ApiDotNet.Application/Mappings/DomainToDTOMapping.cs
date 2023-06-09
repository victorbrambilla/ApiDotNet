using ApiDotNet.Application.DTOs;
using ApiDotNet.Domain.Entities;
using AutoMapper;

namespace ApiDotNet.Application.Mappings
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Purchase, PurchaseDTO>();
            CreateMap<Purchase, PurchaseDetailDTO>()
                .ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person.Name))
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product.Name));
            CreateMap<User, UserDTO>();
            CreateMap<Permission, PermissionDTO>();
        }
    }
}