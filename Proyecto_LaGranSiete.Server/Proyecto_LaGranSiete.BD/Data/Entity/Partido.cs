using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(PartidosId), Name = "PartidosId", IsUnique = true)]
    [Index(nameof(FechaHoraPartidos),
    Name = "FechaHoraPartidos", IsUnique = false)]

    public class Partido : EntityBase
    {
        //Clave primaria de la tabla Partidos
        public int PartidosId { get; set; }

        //clave foránea de la tabla Reserva

        //-----------------------------------------------------
        //Propiedades de la tabla
        //-----------------------------------------------------


        [Required(ErrorMessage = "La fecha y hora del partido es obligatorio")]
        //[MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? FechaHoraPartidos { get; set; }
        //-----------------------------------------------------

        //Clave foranea de la tabla
        public int EquipoUnoId { get; set; }

        public int EquipoDosId { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int CanchasId { get; set; }
        public Cancha? Canchas { get; set; }

        public int PagosId { get; set; }
        public Pago? Pagos { get; set; }

        public int EquiposId { get; set; }
        public Equipo? Equipos { get; set; }

        public int ReservaId { get; set; }
        public Reserva? Reserva { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
        //--------------------------------------------------------

    }
}
