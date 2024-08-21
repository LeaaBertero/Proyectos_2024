using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{

    //Indices de la tabla
    [Index(nameof(CanchasId), Name = "CanchasId", IsUnique = true)]
    [Index(nameof(NombreCancha), nameof(Disponibilidad),
    Name = "NombreCancha_Disponibilidad", IsUnique = false)]

    public class Cancha : EntityBase
    {
        //clave primaria de la tabla 
        public int CanchasId { get; set; }

        //Identificacion de la cancha para el usuario que realiza la reserva

        //----------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------
        [Required(ErrorMessage = "El nombre de la cancha es obligatorio")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreCancha { get; set; }

        //Disponibilidad para el usuario (reservada / libre)

        [Required(ErrorMessage = "El campo disponibilidad es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Disponibilidad { get; set; } //cantidad dde personas por canchas

        //---------------------------------------------------------------------------
        //Relaciones entre tablas
        
        //Partidos
        public int PartidosId { get; set; }
        public Partido? Partidos { get; set; }

        //Pagos
        public int PagosId { get; set; }
        public Pago? Pagos { get; set; }

        //Equipos
        public int EquiposId { get; set; }
        public Equipo? Equipos { get; set; }

        public int ReservaId { get; set; }
        public Reserva? Reserva { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuarios { get; set; }

        //---------------------------------------------------------------------------
    }
}



