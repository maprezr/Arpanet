using System.Collections.Generic;
using System.Linq;
using Arpanet.Dominio;
using Arpanet.Persistencia;

namespace Arpanet.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente 
    
    {
        private readonly AppContext _appContext;

        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

    
        public clsCliente AddCliente(clsCliente cliente)
        {
            var new_cliente = _appContext.cliente.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }

        public void deleteCliente(int idCliente)
        {
            var ClienteEncontrado =
                _appContext.cliente.FirstOrDefault(p => p.Id == idCliente);
            if (ClienteEncontrado == null) return;
            _appContext.Remove (ClienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<clsCliente> getAllCliente()
        {
            return _appContext.cliente;
        }

        public clsCliente getCliente(int idCliente)
        {
            return _appContext.cliente.FirstOrDefault(p => p.Id == idCliente);
        }

        public clsCliente updateCliente(clsCliente cliente)
        {
            var ClienteEncontrado =
                _appContext.cliente.FirstOrDefault(p => p.Id == cliente.Id);
            if (ClienteEncontrado != null)
            {
                ClienteEncontrado.Nombre = cliente.Nombre;
                _appContext.SaveChanges();
            }
            return ClienteEncontrado;
        }
    }
}
