using System.Collections.Generic;
using Arpanet.Dominio;

namespace Arpanet.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<clsCliente> getAllCliente();

        clsCliente addCliente(clsCliente cliente);

        clsCliente updateCliente(clsCliente cliente);

        void deleteCliente(int idCliente);

        clsCliente getCliente(int idCliente);
    }
}
