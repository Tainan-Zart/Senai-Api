using Senai.Domain.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.NovaPasta1
{

    public class EscolaDto
        {
            [Required, MaxLength(60)]
            public string nome { get; set; } = string.Empty;

        }
}



