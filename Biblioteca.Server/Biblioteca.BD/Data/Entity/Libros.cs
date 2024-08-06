using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Libros : EntityBase
    {
        //clave primaria de la tabla
        public int IdLibro { get; set; }
        
        //------------------------------------------
        //Propiedades o atributos de la tabla
        public string? Titulo { get; set; }
        public int? Paginas { get; set; }
        public DateOnly AnioPublicacion { get; set; }
        //-------------------------------------------

        //clave foranea de la tabla
        public int? idBiblioteca { get; set; }
        
        //clave foranea de la tabla
        public int IdAutor { get; set; }
        
        //clave foranea de la tabla
        public int IdGenero { get; set; }
        
        //clave foranea de la tabla
        public int IdEditorial { get; set; }
        
        //clave foranea de la tabla
        public int IdUbicacion { get; set; }
    }
}




