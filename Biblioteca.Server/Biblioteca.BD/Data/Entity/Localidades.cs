using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Localidades : EntityBase
    {
        public string? NombreLocalidad { get; set; }
        public int? Localidad_CP { get; set; }

        //clave foranea de la tabla
        public int ProvinciaId { get; set; }

    }
}
