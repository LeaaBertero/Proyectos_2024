using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proyecto_LaGranSiete.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data
{
    public class Context : DbContext
    {
        //constructor del Context (Base de datos)
        public Context(DbContextOptions options) : base(options)
        {

        }

        //Tablas de la base de datos
        public DbSet<Canchas> Canchas { get; set; }

        public DbSet<Equipos> Equipos { get; set; }
       
        public DbSet<Pagos> Pagos { get; set; }
       
        public DbSet<Partidos> Partidos { get; set; }
        
        public DbSet<Reservas> Reservas { get; set; }
        
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}


        
