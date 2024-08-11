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
        //acá van a ir todas las tablas de la base de datos del proyecto
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Biblio> Biblioteca { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Filas> Filas { get; set; }
        public DbSet<Estanteria> Estanterias { get; set; }
        public DbSet<Columnas> Columnas { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
