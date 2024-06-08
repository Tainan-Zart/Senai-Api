using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.NovaPasta1
{

    public class EscolaDto
        {
            
            public long Id { get; set; }

            [Required, MaxLength(60)]
            public string Nome { get; set; } = string.Empty;
            public EnderecoDto Endereco { get; set; }   

        }
}



