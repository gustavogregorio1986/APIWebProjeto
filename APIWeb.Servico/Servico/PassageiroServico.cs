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
    public class PassageiroServico : IPassageiroServico
    {
        private readonly IPassageiroRepositorio _repositorio;

        public PassageiroServico(IPassageiroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarPassageiro(Passageiro passageiro)
        {
            _repositorio.AdicionarPassageiro(passageiro);
        }

        public Passageiro BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public IEnumerable<Passageiro> ListarPassageiro()
        {
            return _repositorio.ListarPassageiro();
        }

        public void Update(Passageiro passageiro)
        {
            _repositorio.Update(passageiro);
        }
    }
}
