  
using System.Collections.Generic;
using Arpanet.Dominio;

namespace Arpanet.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<clsEmpleado> getAllEmpleado();

        clsEmpleado addEmpleado(clsEmpleado Empleado);

        clsEmpleado updateEmpleado(clsEmpleado Empleado);

        void deleteEmpleado(int idEmpleado);

        clsEmpleado getEmpleado(int idEmpleado);
    }
}