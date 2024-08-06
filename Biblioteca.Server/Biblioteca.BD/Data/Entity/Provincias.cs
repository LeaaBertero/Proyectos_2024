using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Provincias : EntityBase
    {
        //clave primaria de la tabla
        public int IdProvincia { get; set; }

        //-----------------------------------------
        //propiedad o atributo de la tabla
        public string? ProvinciaNombre { get; set; }
    }
}
