using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Genero : EntityBase
    {
        //clave primaria de la tabla
        public int IdGenero { get; set; }

        //----------------------------------------
        //propiedad o atributo de la tabla
        public string? GeneroNombre { get; set; }
        //----------------------------------------
    }
}
