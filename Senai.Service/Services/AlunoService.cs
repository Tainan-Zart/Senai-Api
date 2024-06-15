using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;

namespace Senai.Service.Services;
public class AlunoService : IAlunoService
{
    public readonly IAlunoRepository _alunoRepository;
    public readonly IMapper _mapper;

    public AlunoService(IAlunoRepository alunoRepository, IMapper mapper)
    {
        _mapper = mapper;
        _alunoRepository = alunoRepository;
    }

    public bool Salvar(AlunoDto model)
    {
        var entidade = _mapper.Map<Aluno>(model);
        return _alunoRepository.Salvar(entidade);
    }

    public bool Remover(long id)
    {
        return _alunoRepository.Remover(id);
    }

    public Aluno? BuscarPorId(long id)
    {
        return _alunoRepository.BuscarPorId(id);
    }

    public List<Aluno> BuscarTodos()
    {
        return _alunoRepository.BuscarTodos().ToList();
    }

}
