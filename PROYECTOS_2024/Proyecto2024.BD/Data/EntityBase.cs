using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    //esta clase hereda para el rest de las entidades por la propiedad Id
    public class EntityBase
    {
        public int Id { get; set; }

        public bool Activo { get; set; }

    }
}
