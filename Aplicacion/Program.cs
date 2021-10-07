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
            //GetAllPersona();
            //AddCliente();
            //AddDirectivo();
            //addEmpleado();
            //GetAllEmpleado();
            //getEmpleado(4);
            //deleteEmpleado(3);
            updateEmpleado();
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
            _repoCliente.AddCliente (cliente);
        }

              private static IRepositorioDirectivo
            _repoDirectivo =
                new RepositorioDirectivo(new Persistencia.AppContext());

        private static void AddDirectivo()
        {
            var directivo =
                new clsDirectivo {
                    Categoria = 2
                };
            _repoDirectivo.AddDirectivo (directivo);
        }

        private static IRepositorioEmpleado
            _repoEmpleado =
                new RepositorioEmpleado(new Persistencia.AppContext());

        private static void addEmpleado()
        {
            var empleado =
                new clsEmpleado {
                    Nombre = "Andrés",
                    sueldoBruto = 45963
                };
            _repoEmpleado.addEmpleado (empleado);
        }

       public static void GetAllEmpleado(){
            var Empleado = _repoEmpleado.getAllEmpleado();
            foreach(var empleado in Empleado){
                Console.WriteLine(empleado.Nombre);
            }

            
        }
          public static void getEmpleado(int idEmpleado){
            var empleado = _repoEmpleado.getEmpleado(idEmpleado);
            if(empleado==null)
            return;
            Console.WriteLine(empleado.Nombre); 
        } 
          public static void deleteEmpleado(int idEmpleado){
            _repoEmpleado.deleteEmpleado(idEmpleado);
        }

          public static void updateEmpleado(){
            var empleado = new clsEmpleado{
                Id = 4,
                Nombre = "Juan",
                sueldoBruto = 20450
            };
            _repoEmpleado.updateEmpleado(empleado);
        }

        
    }
}
