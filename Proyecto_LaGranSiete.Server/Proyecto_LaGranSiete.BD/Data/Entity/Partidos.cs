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
    [Index(nameof(IdPartidos), Name = "IdPartidos", IsUnique = true)]
    [Index(nameof(FechaHoraPartidos),
    Name = "FechaHoraPartidos", IsUnique = false)]

    public class Partidos : EntityBase
    {
        //Clave primaria de la tabla Partidos
        public int IdPartidos { get; set; }

        //clave foránea de la tabla Reserva
        public int IdReserva { get; set; }

        //-----------------------------------------------------
        //Propiedades de la tabla
        //-----------------------------------------------------


        [Required(ErrorMessage = "Indique la fecha y hora del partido")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly? FechaHoraPartidos { get; set; }
        //-----------------------------------------------------

        //Clave foranea de la tabla
        public int IdEquipoUno { get; set; }

        public int IdEquipoDos { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int CanchasId { get; set; }
        public Canchas? Canchas { get; set; }
        //--------------------------------------------------------

    }
}
