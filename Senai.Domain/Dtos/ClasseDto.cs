
using Senai.Domain.Enums;

namespace Senai.Domain.Dtos
{
    public class ClasseDto
    {
        public long Id { get; set; }
        public SerieEnum Serie { get; set; }
        public long EscolaId { get; set; }
        public long ProfessorId { get; set; }

    }
}
