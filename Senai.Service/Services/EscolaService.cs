using AutoMapper;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Domain.NovaPasta1;
using Senai.Service.Interfaces;

namespace Senai.Service.Services
{
    public class EscolaService : IEscolaService 
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;
    
        public EscolaService(IEscolaRepository escolaRepository , IMapper mapper)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }

        public bool Adicionar(EscolaDto model) {

            var entidade = _mapper.Map<Escola>(model);
            return _escolaRepository.Adicionar(entidade);
        }

        public bool Remover(long id)
        {
            return _escolaRepository.Remover(id);
        }

        public Escola? BuscarPorId(long id)
        {
           return _escolaRepository.BuscarPorId(id);
        }
    }


}
