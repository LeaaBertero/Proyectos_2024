using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    //El context (:) Hereda de la clase propia del EntityFramework (DbContext), que es funcional a la base de datos 
    public class Context : DbContext
    {
        //acá van las tablas de la base de datos que diseñamos en la carpeta de "Entity(Entidades)"
        public DbSet<TDocumento> TDocumentos { get; set; }

        //clase persona que tiene (Personas)
        public DbSet<Persona> Personas { get; set; }


        //constructor del context (base de datos)
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
