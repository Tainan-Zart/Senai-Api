using Senai.Domain.Entidades;

namespace Senai.Domain.Dtos
{
    public class AlunoDto
    {
        
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public long ClasseId { get; set; }

    }
}
