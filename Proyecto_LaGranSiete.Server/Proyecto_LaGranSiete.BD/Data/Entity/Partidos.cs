using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Partidos : EntityBase
    {
        //Clave primaria de la tabla Partidos
        public int IdPartidos { get; set; }

        //clave foránea de la tabla Reserva
        public int IdReserva { get; set; }

        public DateOnly? FechaHoraPartidos { get; set; }

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
