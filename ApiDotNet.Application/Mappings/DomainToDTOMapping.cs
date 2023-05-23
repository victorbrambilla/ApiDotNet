using ApiDotNet.Application.DTOs;
using ApiDotNet.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Mappings
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() {
            CreateMap<Person, PersonDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Purchase, PurchaseDTO>();
            CreateMap<Purchase, PurchaseDetailDTO>()
                .ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person.Name))
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product.Name));
                
        }
    }
}
