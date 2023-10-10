using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIWeb.Dominio.Dominio
{
    [Table("tb_Passageiro")]
    public class Passageiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomePassageiro { get; set; }

        public string EmailPassageiro { get; set; }

        public string Residencia { get; set; }

        public string Celular { get; set; }

        public string Endereco { get; set; }
    }
}
