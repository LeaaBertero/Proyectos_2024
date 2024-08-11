using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Editorial : EntityBase
    {
        //atributos de la tabla
        public string? NombreEditorial { get; set; }
        public string? Mail_Editorial { get; set; }
        public int? Telefono_Editorial { get; set; }

        public string? Domicilio_Editorial { get; set; }

        public int LocalidadId { get; set; }

        //Tabla que contiene (Libros)
        public Libros? Libro { get; set; }
    }
}
