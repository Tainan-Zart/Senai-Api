using Senai.Domain.Enums;

namespace Senai.Domain.Dtos;
public class NotaDto
{
    public decimal Notas { get; set; }

    public long AlunoId {  get; set; }

    public DisciplinaEnum Disciplina { get; set; }

    public SemestreEnum Semestre { get; set; }
}
