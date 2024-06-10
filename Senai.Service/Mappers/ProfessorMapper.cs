﻿using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Mappers
{
    public class ProfessorMapper : Profile 
    {
        public ProfessorMapper() {

            CreateMap<ProfessorDto, Professor>().ReverseMap();
        }
    }
}
