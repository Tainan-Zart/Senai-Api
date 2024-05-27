using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entidades
{
    public  class Endereco : BaseEntity
    {
        [MaxLength(80)]
        public string Rua {  get; set; } = string.Empty;

        [MaxLength(50)]
        public string Bairro { get; set; } = string.Empty;

        [MaxLength(60)]
        public string Cidade { get; set; } = string.Empty;

        [MaxLength(2)]
        public string Estado { get; set; } = string.Empty;

        public int Numero { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
