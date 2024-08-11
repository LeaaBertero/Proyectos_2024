using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Biblio : EntityBase
    {
        public string? Nombre { get; set; }
        public int? Telefono { get; set; }
        public string? Mail { get; set; }

        public string? Domicilio { get; set; }
        
        //clave foranea de la tabla
        public int IdLocalidad { get; set; }

       
        public Localidades? Localidades { get; set; }

    }
}
