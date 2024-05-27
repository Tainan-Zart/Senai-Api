using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entidades
{
    public class Aluno : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; } = string.Empty;

        [Required, MaxLength(60)]
        public string Sobrenome { get; set; }  

        [Required]
        public DateTime Nascimento { get; set; }

        [Required, MaxLength(14)]
        public string Cpf { get; set; } = string.Empty;

        public long ClasseId { get; set; }

        public Classe Classe { get; set; }

        
    }
}
