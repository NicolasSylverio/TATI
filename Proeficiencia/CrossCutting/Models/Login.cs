using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proeficiencia.CrossCutting.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(16)]
        public string Senha { get; set; }

        [Required]
        public int Tipo { get; set; }
    }
}