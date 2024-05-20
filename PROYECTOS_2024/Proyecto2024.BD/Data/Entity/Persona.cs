using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //para unificar los Id hacer un index
    [Index(nameof(TDocumentoId), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]

    public class Persona : EntityBase
    {

        public string NumDoc { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int TDocumentoId { get; set; }

        public TDocumento TDocumento { get; set;}

    }
}
