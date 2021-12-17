using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurotripViagens.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Display(Name = "ID_Cliente")]
        [Column("ID_Cliente")]

        [Key]
        public int ID_Cliente { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Column("CPF")]
        [Required(ErrorMessage = "Informe o CPF")]
        [StringLength(11)]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        [Required(ErrorMessage = "Informe o Email")]
        [StringLength(30)]
        public string Email { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        [Required(ErrorMessage = "Informe o Endereço")]
        [StringLength(50)]
        public string Endereco { get; set; }

        [Display(Name = "Estado")]
        [Column("Estado")]
        [Required(ErrorMessage = "Informe o Estado")]
        [StringLength(20)]
        public string Estado { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        [Required(ErrorMessage = "Informe a cidade")]
        [StringLength(20)]
        public string Cidade { get; set; }

        [Display(Name = "Destino")]
        [Column("Destino")]
        [Required(ErrorMessage = "Cidade de destino")]
        [StringLength(20)]
        public string Destino { get; set; }

        [Display(Name = "Partida")]
        [Column("Partida")]
        [Required(ErrorMessage = "Cidade da partida")]
        [StringLength(20)]
        public string Partida { get; set; }

        public virtual List<Cliente> Clientes { get; set; }

    }
}
