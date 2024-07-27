using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //indice de la tabla
    [Index(nameof(IdReserva), Name = "ReservaId_UQ", IsUnique = true)]
    [Index(nameof(FechaHoraReserva), nameof(DuracionAlquiler), nameof(Monto),
    nameof(MetodoPago), nameof(EstadoReserva),
    Name = "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva", IsUnique = false)]

    public class Reservas : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int IdReserva { get; set; }

        //Clave foranea de la tabla (Usuarios)
        public int IdUsuario { get; set; }

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------


        //----------------------------------------------------
        [Required(ErrorMessage = "La fecha es obligatoria")]
        [MaxLength(20,ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly FechaHoraReserva { get; set; }


        [Required(ErrorMessage = "La duración del alquiler es obligatoria")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime DuracionAlquiler { get; set; }

        
        [Required(ErrorMessage = "El monto es obligatorio")]
        [MaxLength(12, ErrorMessage = "Máximo número de caracteres {1}")]
        public float Monto { get; set; }

        
        [Required(ErrorMessage = "El método de pago es obligatorio")]
        [MaxLength(25, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? MetodoPago { get; set; }

        
        [Required(ErrorMessage = "El estado de la reserva es obligatoria")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? EstadoReserva { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)
        public int PartidosId { get; set; }
        public Partidos? Partidos { get; set; }
        

        //(Clave primaria de la tabla (Pagos) que se relaciona con la tabla (Reservas))
        public int PagoId { get; set; }
        public Pagos? Pagos { get; set; }
        
        //--------------------------------------------------------

        //Lista de los usuarios que realizan reservas
        //--Renueva la lista por cada usuario que realice una reserva
        public List<Usuarios> Usuarios { get; set; } = new List<Usuarios>();


    }
}
