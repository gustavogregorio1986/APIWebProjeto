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
    public class AviaoServico : IAviaoServico
    {
        private readonly IAviaoRepositorio _repositorio;

        public void AdicionarAviao(Aviao aviao)
        {
            _repositorio.AdicionarAviao(aviao);
        }

        public Aviao BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<Aviao> ListarAviao()
        {
            return _repositorio.ListarAviao();
        }

        public void Update(Aviao aviao)
        {
            _repositorio.Update(aviao);
        }
    }
}
