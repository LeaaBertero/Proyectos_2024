using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Filas : EntityBase
    {
        public int FilaNumero { get; set; }

        public Ubicacion? Ubicacion {get; set;}
    }
}
