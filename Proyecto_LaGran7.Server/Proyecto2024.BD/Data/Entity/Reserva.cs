using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    public class Reserva : EntityBase
    {
        public int? IdUsuario { get; set; }
        public int? IdCancha { get; set; }
        public DateTime? fechaReserva { get; set; }
        public int? IdReserva { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public string? Estado { get; set; }


    }
}
