using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Dtos
{
    internal class AlunoDto
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; } = string.Empty;

        [Required, MaxLength(60)]
        public string Sobrenome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required, MaxLength(14)]
        public string Cpf { get; set; } = string.Empty;
    }
}
