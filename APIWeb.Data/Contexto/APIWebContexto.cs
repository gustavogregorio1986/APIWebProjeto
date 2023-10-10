using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIWeb.Dominio.Dominio;

namespace APIWeb.Data.Contexto
{
    public class APIWebContexto : DbContext
    {
        public APIWebContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Passageiro> Passageiros { get; set; }

        public DbSet<Aviao> Avioes { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Aeroporto> Aeroportos { get; set; }
    }
}
