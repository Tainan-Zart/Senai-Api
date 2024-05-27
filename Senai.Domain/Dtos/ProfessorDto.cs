
using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.NovaPasta1
{
    internal class ProfessorDto
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; } = string.Empty;
    }
}
