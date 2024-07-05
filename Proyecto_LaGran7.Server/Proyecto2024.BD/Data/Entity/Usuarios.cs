using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    public class Usuarios : EntityBase
    {
        public string? Nombre { get; set; }
        public string? Mail { get; set; }
        public string? Contrasenia { get; set; }
        public int? Rol { get; set; }

    }
}
