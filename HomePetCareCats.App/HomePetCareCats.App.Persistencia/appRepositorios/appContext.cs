using Microsoft.EntityFrameworkCore;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public class appContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
         protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HomePetCareCats");
                //en azure se pone "(localdb)\MSSQLLocalDB"
            }
        }
    }
}