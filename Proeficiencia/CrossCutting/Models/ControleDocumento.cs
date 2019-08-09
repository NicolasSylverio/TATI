using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proeficiencia.CrossCutting.Models
{
    [Table("ControleDocumento")]
    public class ControleDocumento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string NomeDocumento { get; set; }

        [Required]
        [MaxLength(200)]
        public string CaminhoArquivo { get; set; }

        public DateTime DataEnvio { get; set; }

        public DateTime? DataValidacao { get; set; }

        public int IdUsuarioEnvio { get; set; }

        public int IdUsuarioValidador { get; set; }

        [MaxLength(200)]
        public string MensagemControle { get; set; }
        
        public bool Erro { get; set; }
    }
}