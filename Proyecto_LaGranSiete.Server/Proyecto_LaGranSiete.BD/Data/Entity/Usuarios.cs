﻿using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    
    public class Usuarios : EntityBase
    {
        //Clave primaria de la tabla
        public int IdUsuario { get; set; }


        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------
        [Required(ErrorMessage = "El campo nombre, es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido, es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "La fecha Nacimiento, es obligatoria")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo teléfono, es obligatorio")]
        [MaxLength(25, ErrorMessage = "Máximo número de caracteres {1}")]
        public  string? Telefono { get; set; } //Telefono

        [Required(ErrorMessage = "El campo e-mail, es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo prentesco, es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Parentesco { get; set; }
        //--------------------------------------------------------



        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int ReservaId { get; set; }
        public Reservas? Reservas { get; set; }
        //--------------------------------------------------------

    }
}
