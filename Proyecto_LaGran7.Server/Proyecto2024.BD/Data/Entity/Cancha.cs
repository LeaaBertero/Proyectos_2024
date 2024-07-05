using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    //primer registro(Tabla)
    public class Cancha : EntityBase
    {
        public string? Nombre { get; set; }  
        public string? Ubicaciòn { get; set; }  
        public string? Estado { get; set; }

    }
}
