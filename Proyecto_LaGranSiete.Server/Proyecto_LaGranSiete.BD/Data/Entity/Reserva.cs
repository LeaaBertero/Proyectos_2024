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
        public DateTime FechaHoraReserva { get; set; }


        [Required(ErrorMessage = "La duración del alquiler es obligatoria")]
        //[MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public int DuracionAlquiler { get; set; }

        
        [Required(ErrorMessage = "El campo Monto, es obligatorio")]
        [MaxLength(5, ErrorMessage = "Máximo número de caracteres {1}")]
        public int Monto { get; set; }

        
        [Required(ErrorMessage = "El campo método de pago, es obligatorio")]
        //[MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? MetodoPago { get; set; } 

        
        [Required(ErrorMessage = "El campo estado de la reserva es obligatoria")]
        //[MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public bool? EstadoReserva { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)
        public int PartidosId { get; set; }
        public Partido? Partidos { get; set; }
        

        //(Clave primaria de la tabla (Pagos) que se relaciona con la tabla (Reservas))
        public int PagoId { get; set; }
        public Pago? Pagos { get; set; }

        //---------------------------------------------------------
        //Relacion entre tablas
        public int EquiposId { get; set; }
        public Equipo? Equipo { get; set; }

        public int PartidoId { get; set; }
        public Partido? Partido { get; set; }

        public int CanchasId { get; set; }
        public Cancha? Canchas { get; set; }

        public int EquipoUnoId { get; set; }
        public EquipoUno? EquipoUno { get; set; }

        public int EquipoDosId { get; set; }
        public EquipoDos? EquipoDos { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }



        //--------------------------------------------------------


        //Lista de los usuarios que realizan reservas
        //--Renueva la lista por cada usuario que realice una reserva
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        //Lista de los usuarios que realizaron reservas
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        public List<Equipo> Equipos { get; set; } = new List<Equipo>();

        //public List<Pago> Pagos { get; set; } = new List<Pago>();


        //Tabla lista


    }
}
