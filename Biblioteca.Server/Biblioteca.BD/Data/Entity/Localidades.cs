using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Localidades : EntityBase
    {
        //clave primaria de la tabla
        public int IdLocalidad { get; set; }

        //------------------------------------------
        //propiedades o atributos de la tabla
        public string? LocalidadNombre { get; set; }
        public int LocalidadCp { get; set; }
        //-------------------------------------------

        //clave foranea de la tabla
        public int IdProvincia { get; set; }
    }
}
