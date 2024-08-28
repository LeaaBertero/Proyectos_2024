using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class EquipoUno : EntityBase
    {
        //-----------------------------
        //clave primaria de la tabla
        //-----------------------------
        public int EquipoUnoID { get; set; }


        //-----------------------------
        //clave foránea de la tabla
        //-----------------------------
        public int ReservaID { get; set; }
        public int UsuarioID { get; set; }
        //-----------------------------
        //clave foránea de la tabla
        //-----------------------------

        //-----------------------------
        //Atributos de la tabla
        //-----------------------------
        public string? NombreEquipoUno { get; set; }
        //-----------------------------
        //Atributos de la tabla
        //-----------------------------
    }
}
