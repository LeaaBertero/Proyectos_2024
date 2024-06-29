using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //indices (restricciones para el usuario, como mensaje, para que sepa que es lo que debe
    //poner como dato para ingresar al sistema y asi evitar que pong cualquier dato)
    [Index(nameof(TDocumentoID), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]
    public class Persona : EntityBase
    {
        public string? NumDoc { get; set; }
        public string? Nombre { get; set; } 

        public string? Apellido { get; set; }

        public int TDocumentoID { get; set; }

        public TDocumento? TDocumento {get; set;}
    }
}
