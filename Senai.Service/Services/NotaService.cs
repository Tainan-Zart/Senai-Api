using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;

namespace Senai.Service.Services;
public  class NotaService : INotaService
{
    public readonly IMapper _mapper;
    public readonly INotaRepository _notaRepository;

    public NotaService(IMapper mapper, INotaRepository notaRepository)
    {
        _mapper = mapper;
        _notaRepository = notaRepository;
    }

    public bool Salvar(NotaDto model)
    {
        var entidade = _mapper.Map<Nota>(model);
        return _notaRepository.Salvar(entidade);
    }

    public List<MediaAlunoDto> MediaNotas(MediaNotasPorAlunoESemestreDto alunoMedia)
    {
        var notasDoaluno = _notaRepository.BuscarTodos().Include(c => c.Aluno)
        .Where(c => c.AlunoId == alunoMedia.AlunoId && c.Semestre == alunoMedia.Semestre)
        .ToList();

        var mediaNotas = new List<MediaAlunoDto>();
        var notasAgupadasPorDisciplina = notasDoaluno.GroupBy(e => e.Disciplina);

        foreach (var notas in notasAgupadasPorDisciplina)
        {
            var media = new MediaAlunoDto()
            {
                Aluno = notasDoaluno.FirstOrDefault(c => c.AlunoId == alunoMedia.AlunoId).Aluno.Nome,
                Disciplina = notas.Key.ToString(),
                Media = notas.Select(d => d.Notas).Sum() / notas.Count()
                
            };
            mediaNotas.Add(media);
        }
        return mediaNotas;

    }


}

