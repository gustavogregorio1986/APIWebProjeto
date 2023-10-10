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
    public class PassageiroRepositorio : IPassageiroRepositorio
    {

        private APIWebContexto _db;

        public PassageiroRepositorio(APIWebContexto db)
        {
            _db = db;
        }

        public void AdicionarPassageiro(Passageiro passageiro)
        {
            _db.Add(passageiro);
            _db.SaveChanges();
        }

        public Passageiro BuscarPorId(int id)
        {
            return _db.Set<Passageiro>().FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _db.Remove(id);
        }

        public IEnumerable<Passageiro> ListarPassageiro()
        {
            return _db.Set<Passageiro>().ToList();
        }

        public void Update(Passageiro passageiro)
        {
            _db.Update(passageiro);
        }
    }
}
