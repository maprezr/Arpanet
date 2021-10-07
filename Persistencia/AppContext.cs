using  Microsoft.EntityFrameworkCore;
using Arpanet.Dominio;

namespace Arpanet.Persistencia
{
    public class AppContext : DbContext
    {
         private const string connectionString = @"Data Source = localhost\sqlexpress;Initial catalog = Arpanet;Integrated Security = True";
        public DbSet<clsPersona> personas   { get ;set ; }
        public DbSet<clsCliente> cliente { get ;set ; }
        public DbSet<clsDirectivo> direcivo { get ;set ; }
        public DbSet<clsEmpleado> empleado { get ;set ; }
        public DbSet<clsEmpresa> empresa { get ;set ; }
        public DbSet<clsFactura> factura { get ;set ; }
        public DbSet<clsProductos> producto { get ;set ; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder
            .UseSqlServer(connectionString);
        }
    } 

    }
                    
}
    
