using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Pago : EntityBase
    {
        //--------------------------
        //clave primaria de la tabla
        //---------------------------
        public int PagoID { get; set; }

        //--------------------------
        //clave foranea de la tabla
        //---------------------------
        public int ReservaID { get; set; }
        //--------------------------
        //clave foranea de la tabla
        //---------------------------


        //--------------------------
        //Atributos de la tabla
        //---------------------------

        public int MontoPagado { get; set; } 
        public string? MetodoPagado { get; set; }
        public DateTime? FechaPagado { get; set; }

        //--------------------------
        //Atributos de la tabla
        //---------------------------
    }
}
