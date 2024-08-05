using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Editorial : EntityBase
    {
        public string? EditorialNombre { get; set; }
        public string? EditorialMail { get; set; }
        public int? EditorialTelefono { get; set; }

        public string? EditorialDomicilio { get; set; }
        public int IdLocalidad { get; set; }
    }
}



