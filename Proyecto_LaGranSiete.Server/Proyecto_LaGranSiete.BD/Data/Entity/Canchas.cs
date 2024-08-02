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
    [Index(nameof(IdCanchas), Name = "IdCanchas", IsUnique = true)]
    [Index(nameof(NombreCancha), nameof(Disponibilidad),
    Name = "NombreCancha_Disponibilidad", IsUnique = false)]

    public class Canchas : EntityBase
    {
        //clave primaria de la tabla 
        public int IdCanchas { get; set; }

        //Identificacion de la cancha para el usuario que realiza la reserva

        //----------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------
        [Required(ErrorMessage = "El nombre de la cancha es obligatorio")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreCancha { get; set; }

        //Disponibilidad para el usuario (si / no)

        [Required(ErrorMessage = "El campo disponibilidad es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public bool? Disponibilidad { get; set; }
    }
}



