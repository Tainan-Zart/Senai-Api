using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;

namespace Senai.Service.Mappers;
public  class NotaMapper : Profile 
{
    public NotaMapper()
    {
        CreateMap<NotaDto, Nota>().ReverseMap();
    }
}
