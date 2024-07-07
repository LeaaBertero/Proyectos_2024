﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{ 
        //Indices
    [Index(nameof(IdUsuario), Name = "UsuarioId_UQ", IsUnique = true)]
    [Index(nameof(Nombre), nameof(Mail), nameof(Contraseña), nameof(Rol), Name = "Persona_Nombre_Mail_Rol", IsUnique = false)]

    public class Usuarios : EntityBase
    {   
        //Clave primaria de la tabla
        [Required(ErrorMessage = "El IdUsuario es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdUsuario { get; set; }

        

        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El nombre es obligatorio")] //Mensaje para el usuario
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")] //Para el frontEnd
        public string? Nombre { get; set; } //Atributos de la tabla


            
        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El E-mail es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Mail { get; set; }



        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(180, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Contraseña { get; set; }



        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El rol es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Rol { get; set; }
        

        
       
        //----------------------------------------------------------------------------------------
        //Relaciones entre tablas
        //-----------------------------------------------------------------------------------------
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int ReservaId { get; set; } //PK - (Clave primaria) de la tabla Reserva que se relaciona con la tabla Usuarios


        //Clave foranea (FK) de la tabla (Reserva), que se relaciona con la tabla Usuarios
        public Reserva? Reserva { get; set; }

        
    }
}
