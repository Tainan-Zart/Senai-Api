using Senai.Domain.Dtos;
using Senai.Domain.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.NovaPasta1
{

    public class EscolaDto
        {
            [Required, MaxLength(60)]
            public string Nome { get; set; } = string.Empty;

           
            public EnderecoDto Endereco { get; set; }   

        }
}



