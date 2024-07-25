using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Reservas : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int IdReserva { get; set; }
        
        //Clave foranea de la tabla (Usuarios)
        public int IdUsuario { get; set; }

        public DateOnly FechaHoraReserva { get; set; }

        public DateTime DuracionAlquiler { get; set; }

        public decimal Monto { get; set; }

        public string? MetodoPago { get; set; }

        public string? EstadoReserva { get; set; }
    }
}
