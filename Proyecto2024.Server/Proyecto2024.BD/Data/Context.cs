using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    //El context (:) Hereda de la clase propia del EntityFramework (DbContext), que es funcional a la base de datos 
    public class Context : DbContext
    {
        //-------------------------------------- IMPORTANTE -------------------------------------------------
        //En este lugar es dónde se realizan las tablas, despues de haber hecho las entidades en la carpeta
        //(Entity)_(Entidades)
        //-------------------------------------- IMPORTANTE -------------------------------------------------

        
        
        //acá van las tablas de la base de datos que diseñamos en la carpeta de "Entity(Entidades)"

        //Tabla TDocumento
        public DbSet<TDocumento> TDocumentos { get; set; }

        //clase persona que tiene (Personas)
        //Tabla Persona
        public DbSet<Persona> Personas { get; set; }

        //Tabla Profesiones
        public DbSet<Profesion>? Profesiones { get; set; }



        //constructor del context (base de datos)
        public Context(DbContextOptions options) : base(options)
        {

        }

        //copiar el codigo del repositorio del profe para bloquear que se borren los datos en cascada

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Éste codigo sirve para evitar que se borren los datos en cascada en la base de datos
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                         .SelectMany(t => t.GetForeignKeys())
                                         .Where(fk => !fk.IsOwnership
                                                      && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }



            base.OnModelCreating(modelBuilder);
        }

    }
}
