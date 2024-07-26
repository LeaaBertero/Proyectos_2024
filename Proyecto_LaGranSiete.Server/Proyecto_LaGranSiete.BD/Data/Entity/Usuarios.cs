using Azure.Core.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Usuarios : EntityBase
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        
        public DateOnly? FechaNacimiento { get; set; }

        public  string? Telefono { get; set; } //Telefono

        public string? CorreoElectronico { get; set; }

        public string? Parentesco { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int ReservaId { get; set; }
        public Reservas? Reservas { get; set; }
        //--------------------------------------------------------

    }
}
