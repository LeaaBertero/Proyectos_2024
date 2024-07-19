using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    //(Indices de la tabla (Cancha)) - (Indice para la PK)
    [Index(nameof(IdCancha), Name = "Cancha_UQ", IsUnique = true)] //Indice para la PK(Clave primaria)
    
    //(Indice para los atributos)
    [Index(nameof(Nombre), nameof(Ubicacion), nameof(Estado), Name = "Nombre_Ubicación_Estado", IsUnique = false)]

    public class Cancha : EntityBase
    {
        //------------------------------------------
        //Clave primaria de la tabla (Cancha)
        public int IdCancha { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Tabla (Pagos), que se relaciona con Tabla (Cancha)
        public Pago? Pagos { get; set; }
        //------------------------------------------


        //------------------------------------------
        //Clave primaria de la tabla (Pagos)
        public int IdPago { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Tabla Reserva que se relaciona con Tabla (Cancha)
        public Reserva? Reservas { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria de la tabla Reserva
        public int ReservaId { get; set; }
        //------------------------------------------



        //----------------------------------------------------------------
        //Atributos de la Tabla (Cancha)
        //----------------------------------------------------------------


        //----------------------------------------------------------------
        //Atributo de la tabla (Cancha)
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }
        //-----------------------------------------------------------------


        //-----------------------------------------------------------------
        //Atributos de la tabla (Cancha)
        [Required(ErrorMessage = "La ubicación de cancha es obligatoria")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Ubicacion { get; set; } //Ubicacion del predio(Dirección -  (Complejo deportivo La Gran 7))
        //------------------------------------------------------------------


        //------------------------------------------------------------------
        //Aributo de la tabla (Cancha)
        [Required(ErrorMessage = "El estado de la cancha es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Estado { get; set; } //disponible // Reservado // Mantenimiento
        //-------------------------------------------------------------------
    }
}

       




