using AutoMapper;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;

namespace Senai.Service.Services;
public class ClasseService : IClasseService
{
    public readonly IClasseRepository _classeRepository;

    public readonly IMapper _mapper;

    public ClasseService(IClasseRepository classeRepository, IMapper mapper)
    {
        _classeRepository = classeRepository;
        _mapper = mapper;
    }

    public bool Salvar(ClasseDto model)
    {
        var entidade = _mapper.Map<Classe>(model);
        return _classeRepository.Salvar(entidade);
    }

    public bool Remove(long id) { 
    
        return _classeRepository.Delete(id);
    }
}
