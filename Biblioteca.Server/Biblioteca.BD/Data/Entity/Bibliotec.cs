using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Bibliotec : EntityBase
    {
        //clave primaria de la tabla
        public int IdBiblioteca { get; set; }

        //------------------------------------
        //propiedades o atribitos de la tabla
        public string? Nombre { get; set; }
        public int? Telefono { get; set; }
        public string? Mail { get; set; }
        public string? Domicilio { get; set; }
        //-------------------------------------
        
        //Clave foranea de la tabla
        public int IdLocalidad { get; set; }
    }
}
