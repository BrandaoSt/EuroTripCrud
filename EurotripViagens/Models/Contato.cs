using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurotripViagens.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Display(Name = "ID_Contato")]
        [Column("ID_Contato")]

        [Key]
        public int ID_Contato { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        [Required(ErrorMessage = "Informe o Email")]
        [StringLength(30)]
        public string Email { get; set; }

        [Display(Name = "Mensagem")]
        [Column("Mensagem")]
        [Required(ErrorMessage = "Digite sua mensagem")]
        [StringLength(500)]
        public string Mensagem { get; set; }

    }
}
