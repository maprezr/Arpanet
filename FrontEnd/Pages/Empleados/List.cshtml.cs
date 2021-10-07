using System.Collections;
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
    public class ListModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;

        public IEnumerable<clsEmpleado> Empleados {get; set;}
        
        public ListModel(IRepositorioEmpleado repositorioEmpleado){
            _repo = repositorioEmpleado;
        }
        public void OnGet()
        {
             Empleados = _repo.getAllEmpleado();
        }
    }
}
