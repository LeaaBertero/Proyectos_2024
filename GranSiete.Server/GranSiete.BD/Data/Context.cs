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
        //control  + . (genera el constructor con opciones )
        public Context(DbContextOptions options) : base(options)
        {

        }

        //acá se agregan todas las entidades de la base de datos

        DbSet<Cancha> Canchas { get; set; }
        DbSet<Equipo> Equipos { get; set; }
        DbSet<EquipoDos> EquipoDos { get; set; }
        DbSet<EquipoUno> EquipoUno { get; set; }
        DbSet<Pago> Pagos { get; set; }
        DbSet<Partido> Partidos { get; set; }
        DbSet<Reserva> Reservas { get; set; }
        DbSet<Usuario> Usuarios { get; set; }


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
