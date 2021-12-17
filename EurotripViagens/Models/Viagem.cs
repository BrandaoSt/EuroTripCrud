using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurotripViagens.Models
{
    [Table("Viagem")]
    public class Viagem
    {
        [Display(Name = "ID_Viagem")]
        [Column("ID_Viagem")]

        [Key]
        public int ID_Viagem { get; set; }

        [Display(Name = "Partida")]
        [Column("Partida")]
        [Required(ErrorMessage = "Informe a cidade de onde irá partir")]
        [StringLength(50)]
        public string Partida { get; set; }

        [Display(Name = "Destino")]
        [Column("Destino")]
        [Required(ErrorMessage = "Informe a cidade de destino")]
        [StringLength(50)]
        public string Destino { get; set; }

        [ForeignKey("Cliente")]
        [Display(Name = "ID_Cliente")]
        [Column("ID_Cliente")]

        public int ID_Cliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
