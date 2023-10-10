using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIWeb.Dominio.Dominio
{
    [Table("tb_Aviao")]
    public class Aviao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Companhia { get; set; }

        public string Poltrona { get; set; }

        public int NumeroVoo { get; set; }

        public DateTime DataPartida { get; set; }

        public DateTime DataChegada { get; set; }

        public Aeroporto Aeroporto { get; set; }

        [ForeignKey("Aeroporto")]
        public int Id_Aeroporto { get; set; }
    }
}
