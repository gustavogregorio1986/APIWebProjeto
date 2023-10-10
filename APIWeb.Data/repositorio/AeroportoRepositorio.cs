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
    public class AeroportoRepositorio : IAeroportoRepositorio
    {
        private APIWebContexto _db;

        public void AdicionarAeroporto(Aeroporto aeroporto)
        {
            _db.Add(aeroporto);
            _db.SaveChanges();
        }

        public Aeroporto BuscarPorId(int id)
        {
            return _db.Set<Aeroporto>().FirstOrDefault(a => a.Id == id);
        }

        public void Delete(int id)
        {
            _db.Remove(id);
        }

        public IEnumerable<Aeroporto> ListarAeroporto()
        {
            return _db.Set<Aeroporto>().ToList();
        }

        public void Update(Aeroporto aeroporto)
        {
            _db.Update(aeroporto);
        }
    }
}
