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
    //indice de la tabla
    //[Index(nameof(ReservaId), Name = "ReservaId_UQ", IsUnique = true)]
    //[Index(nameof(FechaHoraReserva), nameof(DuracionAlquiler), nameof(Monto),
    //nameof(MetodoPago), nameof(EstadoReserva),
    //Name = "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva", IsUnique = false)]

    //------------------ INDICE NUEVO -----------------------

    [Index(nameof(ReservaId), Name = "ReservaId_UQ", IsUnique = true)]

    [Index(nameof(FechaHoraReserva), nameof(DuracionAlquiler), nameof(Monto),
    nameof(MetodoPago), nameof(EstadoReserva),
    Name = "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva", IsUnique = false)]

   
    public class Reserva : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int ReservaId { get; set; }

        //Clave foranea de la tabla (Usuarios)
        

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------


        //----------------------------------------------------
        [Required(ErrorMessage = "La fecha y hora obligatoria")]
        //[MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly? FechaHoraReserva { get; set; }


        //[Required(ErrorMessage = "La duración del alquiler es obligatoria")]
        //[MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public int DuracionAlquiler { get; set; }

        
        [Required(ErrorMessage = "El monto, es obligatorio")]
        [MaxLength(5, ErrorMessage = "Máximo número de caracteres {1}")]
        public double Monto { get; set; }

        
        [Required(ErrorMessage = "El método de pago, es obligatorio")]
        //[MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? MetodoPago { get; set; } 

        
        [Required(ErrorMessage = "El estado de la reserva es obligatoria")]
        //[MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public bool? EstadoReserva { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)
       
        

        //(Clave primaria de la tabla (Pagos) que se relaciona con la tabla (Reservas))
       

        //---------------------------------------------------------
        //Relacion entre tablas
       
        public int EquipoId { get; set; }
        public Equipo? Equipos { get; set; }

        public int PagoId { get; set; }
        public Pago? Pagos { get; set; }

        public int PartidoId { get; set; }
        public Partido? Partidos { get; set; }
        //---------------------------------------------------------






        //--------------------------------------------------------


        //Lista de los usuarios que realizan reservas
        //--Renueva la lista por cada usuario que realice una reserva
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        //Lista de los usuarios que realizaron reservas
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        
        //Tabla lista
    }
}

       




