using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Provincias : EntityBase
    {
        public string? ProvinciaNombre { get; set; }
        public Localidades? Localidades { get; set; }
    }
}
