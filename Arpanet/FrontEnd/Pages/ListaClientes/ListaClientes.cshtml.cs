using System.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Arpanet.Persistencia;
using Arpanet.Dominio;


namespace FrontEnd.Pages
{
    public class ListModel : PageModel
    {
    private readonly IRepositorioCliente _repo;

        public IEnumerable<clsCliente> cliente { get; set; }
        
        public ListModel(IRepositorioCliente repositorioCliente)
        {
            _repo = repositorioCliente;
        }
        
        public void OnGet()
        {
            cliente = _repo.getAllCliente();
        }
     }
}
