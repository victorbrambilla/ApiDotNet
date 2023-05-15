﻿using ApiDotNet.Application.DTOs;
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
        }
    }
}
