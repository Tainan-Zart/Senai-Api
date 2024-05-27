using Senai.Domain.Enums;

namespace Senai.Domain.Entidades
{
    public class Classe : BaseEntity
    {
        public SerieEnum Serie { get; set; }

        public long ClasseId {  get; set; }

        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public long EscolaId { get; set; }

        public Escola Escola { get; set; }
        
       
        public List<Aluno> Alunos { get; set; }  
    }
}
