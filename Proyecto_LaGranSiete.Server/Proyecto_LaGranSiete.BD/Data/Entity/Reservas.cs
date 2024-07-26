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

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------
        public DateOnly FechaHoraReserva { get; set; }

        public DateTime DuracionAlquiler { get; set; }

        public decimal Monto { get; set; }

        public string? MetodoPago { get; set; }

        public string? EstadoReserva { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)
        public int PartidosId { get; set; }
        public Partidos? Partidos { get; set; }
        

        //(Clave primaria de la tabla (Pagos))
        public int PagoId { get; set; }
        public Pagos? Pagos { get; set; }
        
        //--------------------------------------------------------


    }
}
