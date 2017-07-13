using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoComercial.Web.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Nome Completo/ Razão Social")]
        public string NomeCompletoRazaoSocial { get; set; }

        [StringLength(255)]
        [DisplayName("Nome Fantasia")]
        public string ApelidoNomeFantasia { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("CPF/CNPJ")]
        public string CPFCNPJ { get; set; }


    }
}