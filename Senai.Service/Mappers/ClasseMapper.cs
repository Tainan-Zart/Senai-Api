using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;

namespace Senai.Service.Mappers;
public class ClasseMapper : Profile
{
    public ClasseMapper() 
    {
        CreateMap<Classe, ClasseDto>().ReverseMap();
    }

}
