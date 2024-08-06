using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Editorial : EntityBase
    {
        //clave primaria de la tabla
        public int IdEditorial { get; set; }
        
        //-------------------------------------------
        //propiedades o atributos de la tabla
        public string? EditorialNombre { get; set; }
        public string? EditorialMail { get; set; }
        public int? EditorialTelefono { get; set; }
        //--------------------------------------------

        public string? EditorialDomicilio { get; set; }

        //clave foranea de la tabla
        public int IdLocalidad { get; set; }
    }
}



