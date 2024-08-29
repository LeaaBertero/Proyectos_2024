using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Cancha : EntityBase
    {
        //-------------------------------
        //Clave primaria de la tabla
        //-------------------------------
        public int CanchaId { get; set; }
        //-------------------------------
        //Clave primaria de la tabla
        //-------------------------------


        //-------------------------------
        //Atributos de la tabla
        //-------------------------------
        public string? NombreCancha { get; set; }
        
        public string? Disponibilidad { get; set; }
        //-------------------------------
        //Atributos de la tabla
        //-------------------------------
    }
}
