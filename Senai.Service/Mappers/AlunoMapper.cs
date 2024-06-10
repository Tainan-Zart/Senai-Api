using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;

namespace Senai.Service.Mappers;
public class AlunoMapper : Profile 
{
    public AlunoMapper() {

        CreateMap<Aluno, AlunoDto>().ReverseMap();
    }

}
