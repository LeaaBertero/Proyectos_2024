using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    
  

    public class Reserva : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int ReservaId { get; set; }

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------


        //----------------------------------------------------

        [Required(ErrorMessage = "la fecha y hora de la reserva, es obligatoria")]
        public DateTime FechaHoraReserva { get; set; }


        [Required(ErrorMessage = "La duración del alquiler es obligatorio")]
        public int DuracionAlquiler { get; set; }


        [Required(ErrorMessage = "El monto es obligatorio")]
        public decimal Monto { get; set; }


        [Required(ErrorMessage = "El método es obligatorio")]
        public string MetodoPago { get; set; }


        [Required(ErrorMessage = "El estado de la reserva es obligatorio")]
        public string EstadoReserva { get; set; }
        
        

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)



        //(Clave primaria de la tabla (Pagos) que se relaciona con la tabla (Reservas))



      

        //---------------------------------------------------------
        //Relacion entre tablas
       

        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }

        public int EquipoUnoId { get; set; }
        public EquipoUno EquipoUno { get; set; }

        public int EquipoDosId { get; set; }
        public EquipoDos EquipoDos { get; set; }

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }

        public int PagoId { get; set; }
        public Pago Pagos { get; set; }

        public int EquipoId { get; set; }
        public Equipo Equipos { get; set; }

        //Lista de las reservas realizadas por los usuarios
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
        public List<Usuario> Usuario { get; set; } = new List<Usuario>();


        //Tabla lista
    }
}

       




