﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(IdPago), Name = "IdPago", IsUnique = true)]
    [Index(nameof(Monto_Pago), nameof(FechaPago),
    Name = "Monto_Pago_FechaPago", IsUnique = false)]

    public class Pago : EntityBase
    {
        public DateTime fechaHoraReserva;

        //Clave primaria de la tabla
        public int IdPago { get; set; }

        //clave foranea de la tabla Reserva
       

        //------------------------------------------------------
        //Propiedades de la tabla
        //------------------------------------------------------

        [Required(ErrorMessage = "El monto de pago es obligatorio")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public double? Monto_Pago { get; set; }


        [Required(ErrorMessage = "El método de pago es obligatorio")]
        //[MaxLength(15, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? MetodoPagado { get; set; } 



        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        //[MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly FechaPago { get; set; }
        public decimal Monto { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int CanchasId { get; set; }
        public Cancha? Canchas { get; set; }

        public int IdReserva { get; set; }
        public Reserva? Reservas { get; set; }

        public int EquiposId { get; set; }
        public Equipo? Equipos { get; set; }

        public int PartidosId { get; set; }
        public Partido? Partidos { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }



        //--------------------------------------------------------
    }
}