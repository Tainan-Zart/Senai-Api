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


}
