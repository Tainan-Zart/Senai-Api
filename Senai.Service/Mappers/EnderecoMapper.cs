using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Service.Mappers
{
   public  class EnderecoMapper : Profile 
    {
        public EnderecoMapper() 
        {
            CreateMap<EnderecoDto, Endereco>().ReverseMap();
        }
    }
}
