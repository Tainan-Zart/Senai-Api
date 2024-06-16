using Senai.Domain.Dtos;

namespace Senai.Domain.NovaPasta1
{

    public class EscolaDto
        {
            
            public long Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public EnderecoDto Endereco { get; set; }   

        }
}



