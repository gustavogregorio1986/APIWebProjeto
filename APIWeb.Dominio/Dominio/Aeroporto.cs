using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIWeb.Dominio.Dominio
{
    [Table("tb_Aeroporto")]
    public class Aeroporto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }

        public Passageiro Passageiro { get; set; }

        [ForeignKey("Passageiro")]
        public int Id_Passageiro { get; set; }
        public int PassageiroId { get; set; }
    }
}
