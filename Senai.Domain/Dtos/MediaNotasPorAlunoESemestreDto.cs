using Senai.Domain.Entidades;
using Senai.Domain.Enums;

namespace Senai.Domain.Dtos;
public class MediaNotasPorAlunoESemestreDto
{
    public long AlunoId { get; set; }

    public SemestreEnum Semestre { get; set; }
}
