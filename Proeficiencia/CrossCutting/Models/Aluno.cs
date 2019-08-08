using Proeficiencia.CrossCutting.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proeficiencia.CrossCutting.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(16)]
        public string RA { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required]
        public Cursos Curso { get; set; }

        [Required]
        public bool Matriculado { get; set; }
    }
}