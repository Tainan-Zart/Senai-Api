using AutoMapper;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Domain.NovaPasta1;
using Senai.Repository.Repository;
using Senai.Service.Interfaces;

namespace Senai.Service.Services
{
    public class ProfessorService : IProfessorService 
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public bool Salvar(ProfessorDto model)
        {
            var entidade = _mapper.Map<Professor>(model);
            return _professorRepository.Salvar(entidade);
        }

        public bool Excluir (long id)
        {
            var excluir = _professorRepository.Excluir(id);
            return excluir;
        }

        public Professor? BuscarPorId(long id)
        {
           return _professorRepository.BuscarPorId(id);
        }

        public List<Professor> BuscarTodos()
        {
            return _professorRepository.BuscarTodos().ToList();
        }
    }
}
