using APIWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Servico.Servico.Interface
{
    public interface IAeroportoServico
    {
        void AdicionarAeroporto(Aeroporto aeroporto);

        IEnumerable<Aeroporto> ListarAeroporto();

        void Delete(int id);


        void Update(Aeroporto aeroporto);

        Aeroporto BuscarPorId(int id);
    }
}
