using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Ubicacion : EntityBase
    {
        //clave primaria de la tabla
        public int IdUbicacion { get; set; }

        //------------------------------------------
        //propiedades o atributos de la tabla
        public string? UbicacionNombre { get; set; }

        //clave foranea de la tabla
        public int? IdEstanteria { get; set; }
    }
}
