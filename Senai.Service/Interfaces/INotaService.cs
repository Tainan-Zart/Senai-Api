using Senai.Domain.Dtos;

namespace Senai.Service.Interfaces;
public interface INotaService
{
    bool Salvar(NotaDto model);

    List<MediaAlunoDto> MediaNotas(MediaNotasPorAlunoESemestreDto alunoMedia);
}
