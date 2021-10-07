using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Arpanet.Persistencia;
using Arpanet.Dominio;

namespace MyApp.Namespace
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;

        public clsEmpleado empleado { get; set; }

        public CrearModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        } 
        public void OnGet(int id)
        {

        }
        public void OnPost(clsEmpleado empleado){
            _repo.addEmpleado(empleado);
        }
    }
}
