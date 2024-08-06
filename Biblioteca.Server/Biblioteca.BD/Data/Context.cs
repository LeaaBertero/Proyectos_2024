using Biblioteca.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        //tablas del proyecto Biblioteca
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Bibliotec> Bibliotecas { get; set; }
        public DbSet<Columnas> Columnas { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Estanteria> Estanterias { get; set; }
        public DbSet<Filas> Filas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }



        //codigo que evita que un registro de la base de datos, pueda borrarse en cascada
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Éste codigo sirve para evitar que se borren los datos en cascada en la base de datos
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                            .SelectMany(t => t.GetForeignKeys())
                                            .Where(fk => !fk.IsOwnership
                                                        && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {        //Elimina el cmportamiento               
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}






