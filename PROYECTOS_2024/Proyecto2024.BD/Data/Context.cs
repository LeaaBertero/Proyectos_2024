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

        //EN ESTA SECCION DE LA CLASE CONTEXT QUE HEREDA DE DBCONTEXT SE REALIZA LA CREACION DE LAS TABLAS (ENTIDADES)
        //acá van todas las tablas de la base de datos
        public DbSet<TDocumento> TDocumentos { get; set; } //ENTIDAD
        public DbSet<Persona> Personas { get; set; } //ENTIDAD
        public DbSet<Profesion>Profesiones { get; set; } //ENTIDAD 

        //GENERAR ESTE CONSTRUCTOR CON OPCIONES - IMPORTATE EN LA CLASE CONTEXT QUE HEREDA DE DBCONTEXT QUE ES UNA CLASE DEL FRAMEWORKS
        //CONSTRUCTOR con opciones
        public Context(DbContextOptions options) : base(options)
        {

        }




        //éste método evita que la base de datos pueda borrarse en cascada
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
