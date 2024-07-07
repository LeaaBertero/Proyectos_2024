using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoLaGran7.BD.Data.Entity
{
    [Index(nameof(IdReserva), Name = "ReservaId_UQ", IsUnique = true)]
    [Index(nameof(fechaReserva), nameof(HoraInicio), nameof(HoraFin), nameof(Estado), Name = "fechaReserva_HoraInicio_HoraFin_Estado", IsUnique = false)]

    public class Reserva : EntityBase
    {
        //----------------------------------------------------------------------
        //(PK) - Clave primaria de la tabla (Reserva)
        //----------------------------------------------------------------------
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdReserva { get; set; }


        //(FK) - Clave foranea de la tabla (Reserva)
        [Required(ErrorMessage = "El usuario es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdUsuario { get; set; }


        //(FK) - Clave foránea de la tabla (Reserva)
        [Required(ErrorMessage = "El número de ID de la cancha es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? IdCancha { get; set; }







        //-----------------------------------------------------------------------------
        //Atributos de la tabla (Reserva)
        //------------------------------------------------------------------------------

        //Atributo de la tabla
        [Required(ErrorMessage = "Indique la fecha para la reserva")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? fechaReserva { get; set; }



        
        //Atributo de la tabla
        [Required(ErrorMessage = "Indique la hora de inicio para la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? HoraInicio { get; set; }   

        


        //Atributo de la tabla
        [Required(ErrorMessage = "Indique la hora de finalización de la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? HoraFin { get; set; }
        



        //Atributo de la tabña (Reserva)
        [Required(ErrorMessage = "Indique el estado de la reserva")] //Pendiente // Cancelada
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Estado { get; set; }





        
        
        
        //Relaciones entre tablas(Lista de los usuarios)
        public List<Usuarios>? Usuarios { get; set; }
        
    }
}
      




        
      
        
        
        
        
       
        
        

