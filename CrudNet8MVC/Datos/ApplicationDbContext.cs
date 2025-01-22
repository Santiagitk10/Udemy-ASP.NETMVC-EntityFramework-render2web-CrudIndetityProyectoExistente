using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        //Agregar los modelos aquí (Cada modelo corresponde a una tabla en la BD)
        public DbSet<Contacto> Contacto { get; set; }
    }
}
