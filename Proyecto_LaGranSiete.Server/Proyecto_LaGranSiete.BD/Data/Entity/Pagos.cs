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

        //------------------------------------------------------
        //Propiedades de la tabla
        //------------------------------------------------------
        public decimal? Monto_Pago { get; set; }

        public DateOnly FechaPago { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int CanchasId { get; set; }
        public Canchas? Canchas { get; set; }
        //--------------------------------------------------------
    }
}
