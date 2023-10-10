using APIWeb.Data.repositorio.Interface;
using APIWeb.Dominio.Dominio;
using APIWeb.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Servico.Servico
{
    public class PagamentoServico : IPagamentoServico
    {

        private readonly IPagamentoRepositorio _repositorio;

        public void AdicionarPagamento(Pagamento pagamento)
        {
            _repositorio.AdicionarPagamento(pagamento);
        }

        public Pagamento BuscarPorId(int id)
        {
           return _repositorio.BuscarPorId(id);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<Pagamento> ListarPagamento()
        {
            return _repositorio.ListarPagamento();
        }

        public void Update(Pagamento pagamento)
        {
            _repositorio.Update(pagamento);
        }

    }
}
