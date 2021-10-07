using System.Collections.Generic;
using System.Linq;
using Arpanet.Dominio;
using Arpanet.Persistencia;

namespace Arpanet.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

    
        public clsPersona addPersona(clsPersona persona)
        {
            var new_persona = _appContext.personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }

        public void deletePersona(int idPersona)
        {
            var PersonaEncontrada =
                _appContext.personas.FirstOrDefault(p => p.Id == idPersona);
            if (PersonaEncontrada == null) return;
            _appContext.Remove (PersonaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<clsPersona> getAllPersona()
        {
            return _appContext.personas;
        }

        public clsPersona getPersona(int idPersona)
        {
            return _appContext.personas.FirstOrDefault(p => p.Id == idPersona);
        }

        public clsPersona updatePersona(clsPersona persona)
        {
            var PersonaEncontrada =
                _appContext.personas.FirstOrDefault(p => p.Id == persona.Id);
            if (PersonaEncontrada != null)
            {
                PersonaEncontrada.Nombre = persona.Nombre;
                _appContext.SaveChanges();
            }
            return PersonaEncontrada;
        }
    }
}
