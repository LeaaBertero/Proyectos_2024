using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Libros : EntityBase
    {
        //atributos de la tabla
        public string? Titulo { get; set; }
        public int Paginas { get; set; }
        public int AnioPublicacion { get; set; }

        //clave foranea de la tabla
        public int IdBiblioteca { get; set; }
        public int IdAutor { get; set; }
        public int IdGenero { get; set; }
        public int IdEditorial { get; set; }
        public int IdUbicacion { get; set; }

        public Libros? Libro { get; set; }

        public Ubicacion? Ubicacion { get; set; }




    }
}
