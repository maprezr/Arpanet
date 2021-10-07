using System.Collections.Generic;
using System.Linq;
using Arpanet.Dominio;
using Arpanet.Persistencia;

namespace Arpanet.Persistencia
{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AppContext _appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            _appContext = appContext;
        }

    
        public clsDirectivo AddDirectivo(clsDirectivo directivo)
        {
            var new_directivo = _appContext.direcivo.Add(directivo);
            _appContext.SaveChanges();
            return new_directivo.Entity;
        }

        public void deleteDirectivo(int idDirectivo)
        {
            var DirectivoEncontrado =
                _appContext.direcivo.FirstOrDefault(p => p.Id == idDirectivo);
            if (DirectivoEncontrado == null) return;
            _appContext.Remove (DirectivoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<clsDirectivo> getAllDirectivo()
        {
            return _appContext.direcivo;
        }

        public clsDirectivo getDirectivo(int idDirectivo)
        {
            return _appContext.direcivo.FirstOrDefault(p => p.Id == idDirectivo);
        }

        public clsDirectivo updateDirectivo(clsDirectivo directivo)
        {
            var DirectivoEncontrado =
                _appContext.direcivo.FirstOrDefault(p => p.Id == directivo.Id);
            if (DirectivoEncontrado != null)
            {
                DirectivoEncontrado.Categoria = directivo.Categoria;
                _appContext.SaveChanges();
            }
            return DirectivoEncontrado;
        }
    }
}