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
    public class AviaoRepositorio : IAviaoRepositorio
    {
        private APIWebContexto _db;

        public AviaoRepositorio(APIWebContexto db)
        {
            _db = db;
        }
        public void AdicionarAviao(Aviao aviao)
        {
            _db.Add(aviao);
            _db.SaveChanges();
        }

        public Aviao BuscarPorId(int id)
        {
            return _db.Set<Aviao>().FirstOrDefault(a => a.Id == id);
        }

        public void Delete(int id)
        {
            _db.Remove(id);
        }

        public IEnumerable<Aviao> ListarAviao()
        {
            return _db.Set<Aviao>().ToList();
        }

        public void Update(Aviao aviao)
        {
            _db.Update(aviao);
        }
    }
}
