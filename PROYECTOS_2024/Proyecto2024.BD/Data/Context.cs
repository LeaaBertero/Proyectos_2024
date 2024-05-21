using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    //Base de datos de Context
    public class Context : DbContext
    {
        //para agregar tablas, se realiza acá en en Context
        //DbSet --> es de la misma clase que DbContext
        public DbSet<TDocumento> TDocumentos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesion>Profesiones { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        //sobre escribiendo un metodo de la creacion de la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                          .SelectMany(t => t.GetForeignKeys())
                                          .Where(fk => !fk.IsOwnership
                                                       && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict; //restricciones de todas las claves foraneas
            }

            //evita que la base de datos se borre en cascada
            base.OnModelCreating(modelBuilder);

        }
    }
}
