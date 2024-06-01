using AutoMapper;
using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Service.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() 
        {
            CreateMap<EscolaDto, Escola>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
