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

        //------------------------------------------
        //Clave primaria de la tabla (Reserva)
        public int? IdReserva { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria de la tabla Usuarios
        public int? IdUsuario { get; set; }
        //------------------------------------------


        //------------------------------------------
        //Clave Primaria de la tabla (Cancha), que se relaciona con la tabla (Reserva)
        public int? IdCancha { get; set; }
        //------------------------------------------





        [Required(ErrorMessage = "Indique la fecha para la reserva")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]

        //El usuario va a saber la fecha en que realizó la reserva
        public DateTime? fechaReserva { get; set; }



        
       
        [Required(ErrorMessage = "Hora de inicio para la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]

        //El usuario va a saber la hora de inicio de la reserva 
        public DateTime? HoraInicio { get; set; }   

        


        
        [Required(ErrorMessage = "Hora de finalización de la reserva")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]

        //El usuario va a saber la hora de finalizacón de la reserva
        public DateTime? HoraFin { get; set; }
        


      
        [Required(ErrorMessage = "Indique el estado de la reserva")] 
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]

        // Condiciones de solicitudes // -- //Pendiente // Cancelada //Aprobada
        public string? Estado { get; set; }


        //Lista de los usuarios que reservaron la reserva de una cancha 
        public List<Usuario>? Usuarios { get; set; }

    }
}
        
        
      




        
      
        
        
        
        
       
        
        

