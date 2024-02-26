//Importar el espacio de nombres necesario para DbContext.
using Microsoft.EntityFrameworkCore;
using CRM.API.Models.EN;

//Define la clase CRMContext que hereda Dbcontext
namespace CRM.API.Models.DAL
{
    public class CRMContext : DbContext
    {
       //Constructor que toma DbConextOptions como parametro para configurar la conexion de la base de datos.
       
        public CRMContext(DbContextOptions<CRMContext> options) : base(options)
        {
        }

       //Define un DbSet llamado "Customers" que respresenta una tabla de clientes en la base de datos.

        public DbSet<Customer> Customers { get; set; }
    }

}