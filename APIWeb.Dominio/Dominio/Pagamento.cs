using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIWeb.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public float Preco { get; set; }

        public int QtdePassageiro { get; set; }

        public Aviao Aviao { get; set; }

        [ForeignKey("Aviao")]
        public int Id_Aviao { get; set; }
    }
}
