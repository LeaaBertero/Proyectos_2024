using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Ubicacion : EntityBase
    {
        public string? UbicacionNombre { get; set; }

        public int IdEstanteria { get; set; }

        public Estanteria? Estanteria { get; set; }

        public Columnas? Columnas { get; set; }
    }
}
