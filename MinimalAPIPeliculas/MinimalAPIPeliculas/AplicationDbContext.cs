using Microsoft.EntityFrameworkCore;
using MinimalAPIPeliculas.Entidades;
using System.Data.Common;

namespace MinimalAPIPeliculas
{
    //context == la base de datos que hereda de DbContext(clase del framework)
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        //aca van todas las tablas
        public DbSet<Genero> Generos { get; set; }
    }
}
