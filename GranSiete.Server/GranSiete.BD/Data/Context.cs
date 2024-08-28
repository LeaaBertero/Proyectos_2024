using GranSiete.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data
{
    public class Context : DbContext
    {
        //acá se agregan todas las entidades de la base de datos

        DbSet<Cancha> Canchas { get; set; }
        DbSet<Equipo> Equipos { get; set; }
        DbSet<EquipoDos> EquipoDos { get; set; }
        DbSet<EquipoUno> EquipoUno { get; set; }
        DbSet<Pago> Pagos { get; set; }
        DbSet<Partido> Partidos { get; set; }
        DbSet<Reserva> Reservas { get; set; }
        DbSet<Usuario> Usuarios { get; set; }



        //control  + . (genera el constructor con opciones )
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
