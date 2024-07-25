using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Pagos : EntityBase
    {
        //Clave primaria de la tabla
        public int IdPago { get; set; }

        //clave foranea de la tabla Reserva
        public int IdReserva { get; set; }

        public decimal? Monto_Pago { get; set; }

        public DateOnly FechaPago { get; set; }
    }
}
