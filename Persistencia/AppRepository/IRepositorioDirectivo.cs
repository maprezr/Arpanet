using System.Collections.Generic;
using Arpanet.Dominio;

namespace Arpanet.Persistencia
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<clsDirectivo> getAllDirectivo();

        clsDirectivo AddDirectivo(clsDirectivo direcivo);

        clsDirectivo updateDirectivo(clsDirectivo direcivo);

        void deleteDirectivo(int idDirectivo);

        clsDirectivo getDirectivo(int idDirectivo);
         
    }
}