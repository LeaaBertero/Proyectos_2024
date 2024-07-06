using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    [Index(nameof(ReservaId), Name = "Usuario_UQ", IsUnique = true)]
    [Index(nameof(Nombre), nameof(Mail), nameof(Contraseña), nameof(Rol), Name = "Persona_Nombre_Mail_Rol", IsUnique = false)]
    public class Usuarios : EntityBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El E-mail es obligatorio")]
        public string? Mail { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string? Contraseña { get; set; }
        [Required(ErrorMessage = "El rol es obligatorio")]
        public int? Rol { get; set; }

        //relaciones entre tablas
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        public int ReservaId { get; set; }

        public Reserva? Reserva { get; set; }
    }
}
