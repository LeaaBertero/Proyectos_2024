using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Autor : EntityBase
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public Libros? Libros { get; set; }
    }
}

