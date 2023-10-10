using APIWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Servico.Servico.Interface
{
    public interface IPassageiroServico
    {
        void AdicionarPassageiro(Passageiro passageiro);

        IEnumerable<Passageiro> ListarPassageiro();

        void Delete(int id);


        void Update(Passageiro passageiro);

        Passageiro BuscarPorId(int id);
    }
}
