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
    public class AeroportoServico : IAeroportoServico
    {
        private readonly IAeroportoRepositorio _repositorio;

        public void AdicionarAeroporto(Aeroporto aeroporto)
        {
            _repositorio.AdicionarAeroporto(aeroporto);
        }

        public Aeroporto BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<Aeroporto> ListarAeroporto()
        {
            return _repositorio.ListarAeroporto();
        }

        public void Update(Aeroporto aeroporto)
        {
            _repositorio.Update(aeroporto);
        }
    }
}
