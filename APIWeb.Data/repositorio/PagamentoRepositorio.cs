using APIWeb.Data.Contexto;
using APIWeb.Data.repositorio.Interface;
using APIWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Data.repositorio
{
    public class PagamentoRepositorio : IPagamentoRepositorio
    {
        private APIWebContexto _db;


        public void AdicionarPagamento(Pagamento pagamento)
        {
            _db.Add(pagamento);
            _db.SaveChanges();
        }

        public Pagamento BuscarPorId(int id)
        {
            return _db.Set<Pagamento>().FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
             _db.Remove(id);
        }

        public IEnumerable<Pagamento> ListarPagamento()
        {
            return _db.Set<Pagamento>().ToList();
        }

        public void Update(Pagamento pagamento)
        {
            _db.Update(pagamento);
        }
    }
}
