using Senai.Domain.Enums;

namespace Senai.Domain.Entidades;
public class Nota : BaseEntity
{
    public decimal Notas {  get; set; }

    public DisciplinaEnum Disciplina { get; set; }

    public SemestreEnum Semestre { get; set; }

    public  long  AlunoId { get; set; }

    public Aluno Aluno { get; set; }
}
