using System.Collections.Generic;
using Dominio.Entidades;
namespace Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable <clsPersona> getAllPersona();

        clsPersona addPersona(clsPersona persona);

        clsPersona updatePersona (clsPersona persona);

        void deletePersona (int idPersona);

        clsPersona getPersona(int idPersona);

    }
}