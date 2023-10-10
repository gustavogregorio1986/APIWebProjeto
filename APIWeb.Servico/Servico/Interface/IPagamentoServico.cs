using APIWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Servico.Servico.Interface
{
    public interface IPagamentoServico
    {
        void AdicionarPagamento(Pagamento pagamento);

        IEnumerable<Pagamento> ListarPagamento();

        void Delete(int id);


        void Update(Pagamento pagamento);

        Pagamento BuscarPorId(int id);
    }
}
