namespace Senai.Domain.Dtos
{
    public class EnderecoDto
    {
        
        public long Id { get; set; }
        public string Rua { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
