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
        //Tabla (Cancha)
        public DbSet<Cancha> Cancha { get; set; }

        //Tabla (Pago)
        public DbSet<Pago> Pago { get; set; }

        //Tabla (Usuarios)
        public DbSet<Usuarios> Usuarios { get; set; }

        //Tabla (Reserva)
        public DbSet<Reserva> Reserva { get; set; }
        
        //constructor del context que (hereda) del DBContext
        public Context(DbContextOptions options) : base(options)
        {
                
        }
    }
}
