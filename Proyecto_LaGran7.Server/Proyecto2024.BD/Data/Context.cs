using Microsoft.EntityFrameworkCore;
using ProyectoLaGran7.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    public class Context : DbContext
    {
        //Acá es el lugar donde van todas las tablas 

        //Tablas de la base de datos que se encuentra en el context, que es la base de datos
        //Tabla (Cancha)
        public DbSet<Cancha> Cancha { get; set; }

        //Tabla (Pago)
        public DbSet<Pago> Pago { get; set; }

        //Tabla (Usuarios)
        public DbSet<Usuarios> Usuarios { get; set; }

        //Tabla (Reserva)
        public DbSet<Reserva> Reserva { get; set; }
        

        //---------------------------------------------------------
        //Constructor - - - - - - - - - - - - - - - - - - - - - - - 
        //---------------------------------------------------------
        //constructor del context que (hereda) del DBContext
        //Constructor con opciones que hereda de DBContext(Base de datos)
        public Context(DbContextOptions options) : base(options)
        {
                
        }


        //codigo que evita que un registro de la base de datos, pueda borrarse en cascada
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


