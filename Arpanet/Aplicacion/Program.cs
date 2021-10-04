using System;
using System.Collections.Generic;
using Arpanet.Dominio;
using Arpanet.Persistencia;

namespace Arpanet.Aplicacion
{
    class Program
    {
        private static IRepositorioPersona
            _repoPersona =
                new RepositorioPersona(new Persistencia.AppContext()); // esta linea no me la he entendido muy bien

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! EF ARPANET");

            //AddPersona();
            //updatePersona();
            //deletePersona(7);
            //getPersona(2);
            GetAllPersona();
            AddCliente();
        }

        public static void GetAllPersona()
        {
            IEnumerable<clsPersona> pesonas = _repoPersona.getAllPersona();
            foreach (clsPersona persona in pesonas)
            {
                Console.WriteLine(persona.Nombre);
            }
        }

        public static void getPersona(int IdPersona)
        {
            clsPersona persona = _repoPersona.getPersona(IdPersona);
            if (persona == null) return;
            Console.WriteLine(persona.Nombre);
        }

        public static void deletePersona(int IdPersona)
        {
            _repoPersona.deletePersona (IdPersona);
        }

        public static void updatePersona()
        {
            var persona = new clsPersona { Id = 7, Nombre = "jose" };
            _repoPersona.updatePersona (persona);
        }

        public static void AddPersona()
        {
            var persona = new clsPersona { Nombre = "camilo" };
            _repoPersona.addPersona (persona);
        }

        private static IRepositorioCliente
            _repoCliente =
                new RepositorioCliente(new Persistencia.AppContext());

        private static void AddCliente()
        {
            var cliente =
                new clsCliente {
                    Nombre = "Alex",
                    Telefono = "3128547806"
                };
            _repoCliente.addCliente (cliente);
        }
    }
}
