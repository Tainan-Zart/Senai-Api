using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entidades
{
    public class Professor : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; } = string.Empty;

        public long EscolaId { get; set; }

        public Escola Escola { get; set;}

        public Classe Classe { get; set; }
    }
}
