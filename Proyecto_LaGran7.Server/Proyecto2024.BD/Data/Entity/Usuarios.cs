using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    [Index(nameof(ReservaId), Name = "Usuario_UQ", IsUnique = true)]
    [Index(nameof(Nombre), nameof(Mail), nameof(Contrasenia), nameof(Rol), Name = "Persona_Nombre_Mail_Rol", IsUnique = false)]
    public class Usuarios : EntityBase
    {
        public string? Nombre { get; set; }
        public string? Mail { get; set; }
        public string? Contrasenia { get; set; }
        public int? Rol { get; set; }

        //relaciones entre tablas
        public int ReservaId { get; set; }

        public Reserva? Reserva { get; set; }
    }
}
