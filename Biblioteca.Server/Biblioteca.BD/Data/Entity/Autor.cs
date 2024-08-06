using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Autor : EntityBase
    {   
        //clave primaria de la tabla
        public int IdAutor { get; set; }

        //-----------------------------------
        //propiedades o atributo de la tabla
        public string? Apellido { get; set; }
        public string? Nombre { get; set; }


    }
}
