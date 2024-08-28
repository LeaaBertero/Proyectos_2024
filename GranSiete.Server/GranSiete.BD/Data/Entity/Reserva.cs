using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Reserva : EntityBase
    {
        //-----------------------------
        //Clave primaria de la tabla
        //-----------------------------
        public int ReservaID { get; set; }

        //-----------------------------
        //Clave foránea de la tabla
        //-----------------------------
        public int UsuarioID { get; set; }



        //-----------------------
        //Atributos de la tabla
        //-----------------------
        public DateTime? FechaHoraReserva { get; set; }
        public DateTime? DuracionAlquiler { get; set; }
        public int Monto { get; set; }

        public string? MetodoPago { get; set; }

        public string? EstadoReserva { get; set; }
        //-----------------------
        //Atributos de la tabla
        //-----------------------
    }
}
