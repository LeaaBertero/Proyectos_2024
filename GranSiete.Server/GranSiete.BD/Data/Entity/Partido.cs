using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Partido : EntityBase
    {
        //------------------------------
        //Clave primaria de la tabla
        //------------------------------
        public int PartidoId { get; set; } 


        //----------------------------------
        //clave foranea de la tabla
        //----------------------------------
        public int ReservaID { get; set; }
       
        public int EquipoUnoID { get; set; }
        
        public int EquipoDosID { get; set; }
        
        //----------------------------------
        //clave foranea de la tabla
        //----------------------------------



        //----------------------------------
        //atributos de la tabla
        //----------------------------------
        public DateTime? FechaHoraPartidos { get; set; }
        
    }
}
