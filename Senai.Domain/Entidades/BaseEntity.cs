using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entidades
{
   public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
