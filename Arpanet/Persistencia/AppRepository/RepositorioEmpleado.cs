using System.Collections.Generic;
using Dominio.Entidades;
using System.Linq;

namespace Persistencia 
{

     
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
            private readonly AppContext _appContext;

        public RepositorioEmpleado (AppContext appContext){
            _appContext = appContext;
        }



        public clsEmpleado addEmpleado(clsEmpleado empleado)
        {
            var new_empleado = _appContext.empleado.Add(empleado);
            _appContext.SaveChanges();
            return new_empleado.Entity;
        }   

        public void deleteEmpleado(int idEmpleado)
        {
            var EmpleadoEncontrado = _appContext.empleado.FirstOrDefault(
                p => p.Id == idEmpleado
            );
            if(EmpleadoEncontrado == null)
                return;
            _appContext.Remove(EmpleadoEncontrado);
            _appContext.SaveChanges();

        }

        public IEnumerable<clsEmpleado> getAllEmpleado()
        {
            return _appContext.empleado;

        }

        public clsEmpleado getEmpleado(int idEmpleado)
        {
            return _appContext.empleado.FirstOrDefault(
                p => p.Id == idEmpleado
            );
        }

        public clsEmpleado updateEmpleado(clsEmpleado empleado)
        {
            var EmpleadoEncontrado = _appContext.empleado.FirstOrDefault(
            p => p.Id == empleado.Id
            );
            if (EmpleadoEncontrado != null){
                EmpleadoEncontrado.Nombre = Empleado.Nombre;
                _appContext.SaveChanges();
            }
            return EmpleadoEncontrado;


        }
    }
}