using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Equipo : EntityBase
    {   
        //------------------------------
        //clave primaria de la tabla
        //------------------------------
        public int EquipoId { get; set; }



        //------------------------------
        //Atributos de la tabla
        //------------------------------
        public string? NombreEquipos { get; set; }
        public string? Integrantes { get; set; }

        //------------------------------
        //Atributos de la tabla
        //------------------------------
    }
}
