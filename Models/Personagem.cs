using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dragon_Ball.Models
{
    [Table("DBZ")]
    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome não pode exceder 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "tipo é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tpo não pode exceder 50 caracteres")]
        public string Tipo { get; set; }

    }
}
