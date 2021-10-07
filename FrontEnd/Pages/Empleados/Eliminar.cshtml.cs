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
    public class EliminarModel : PageModel
    {
         private readonly IRepositorioEmpleado _repo;

        public clsEmpleado empleado { get; set; }

        public EliminarModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        } 
        public void OnGet(int id)
        {
            empleado = _repo.getEmpleado(id);
        }
          public void OnPost(int id){
            _repo.deleteEmpleado(id);
        }
    }
}
