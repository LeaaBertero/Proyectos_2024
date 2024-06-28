using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lagran7.BD.Data.Entity //ubicacion de cada entidad
{
    public class TDocumento : EntityBase
    {
        public string? Codigo { get; set; }

        public string? Nombre { get; set; }
    }
}
