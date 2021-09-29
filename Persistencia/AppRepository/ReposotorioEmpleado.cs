using System.Collections.Generic;
using Dominio.Entidades;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEMpleado : IRepositorioEmpleado
    {

        private readonly AppContext _appContext;

        public RepositorioEMpleado(AppContext appContext){
            _appContext = appContext;
        }
        
        clsEmpleado IRepositorioEmpleado.addEmpleado(clsEmpleado empleado)
        {
            var new_empleado = _appContext.empleado.Add(empleado);
            _appContext.SaveChanges();
            return new_empleado.Entity;
        }

        void IRepositorioEmpleado.deleteEmpleado(int idEmpleado)
        {
            var EmpleadoEncontrado = _appContext.empleado.FirstOrDefault(
                p => p.id == idEmpleado
            );
            if(EmpleadoEncontrado == null)
                return ;
                _appContext.Remove(EmpleadoEncontrado);
                _appContext.SaveChanges();
            
        }

        IEnumerable<clsEmpleado> IRepositorioEmpleado.GetAllEmpleado()
        {
            return _appContext.empleado;
        }

        clsEmpleado IRepositorioEmpleado.GetEmpleado(int idEmpleado)
        {
            return _appContext.empleado.FirstOrDefault(
                p => p.id == idEmpleado
            );
        }

        clsEmpleado IRepositorioEmpleado.updateEmpleado(clsEmpleado empleado)
        {
            var EmpleadoEncontrado = _appContext.empleado.FirstOrDefault(
                p => p.id == empleado.id
            );
            if (EmpleadoEncontrado != null){
                EmpleadoEncontrado.sueldoBruto = empleado.sueldoBruto;
                _appContext.SaveChanges();
            }
            return EmpleadoEncontrado;
        }
    }
}