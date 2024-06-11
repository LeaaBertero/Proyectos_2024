﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class Profesion : EntityBase
    {
        [Required(ErrorMessage = "La persona es obligatoria")]
        public int PersonaId { get; set; }
        public Persona Persona { get; set; } //clase persona hereda de entityBase



        [Required(ErrorMessage = "El título es obligatorio")]
        public int TituloId { get; set; }
        public Titulo Titulo { get; set; } //clase titulo tambien hereda de entityBase


    }
}
