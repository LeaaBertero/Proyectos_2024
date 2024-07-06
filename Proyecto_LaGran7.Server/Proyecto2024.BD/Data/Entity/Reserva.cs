using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    public class Reserva : EntityBase
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdUsuario { get; set; }

        
        [Required(ErrorMessage = "El número de identificación de la cancha es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdCancha { get; set; }

        
        [Required(ErrorMessage = "Indique la fecha para la reserva")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? fechaReserva { get; set; }

        
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdReserva { get; set; }

        
        [Required(ErrorMessage = "Indique la hora de inicio para la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? HoraInicio { get; set; }


        [Required(ErrorMessage = "Indique la hora de finalización de la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? HoraFin { get; set; }

        [Required(ErrorMessage = "Indique el estado de la reserva")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Estado { get; set; }

        //Relaciones entre tablas


    }
}
