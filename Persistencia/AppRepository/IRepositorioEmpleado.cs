using System.Collections.Generic;
using Dominio.Entidades;
namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<clsEmpleado> GetAllEmpleado();

         clsEmpleado addEmpleado(clsEmpleado empleado);

         clsEmpleado updateEmpleado(clsEmpleado empleado);

         void deleteEmpleado(int idEmpleado);

         clsEmpleado GetEmpleado(int idEmpleado);

    }
}