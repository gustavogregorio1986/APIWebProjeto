using APIWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWeb.Data.repositorio.Interface
{
    public interface IAviaoRepositorio
    {
        void AdicionarAviao(Aviao aviao);

        IEnumerable<Aviao> ListarAviao();

        void Delete(int id);


        void Update(Aviao aviao);

        Aviao BuscarPorId(int id);
    }
}
