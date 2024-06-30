using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class Profesion : EntityBase
    {
        //mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "La persona es obligatoria")]
        public int PersonaId { get; set; }



        //Ésta es una propiedad que se relaciona a la persona,
        //es decir la clase (TDocumento como objeto y la propiedad del objeto en si..)
        public Persona? Persona { get; set; }


        //mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "El titulo es obligatorio")]
        public int TituloId { get; set; }



        //Ésta es una propiedad que se relaciona a la persona,
        //es decir la clase (TDocumento como objeto y la propiedad del objeto en si..)
        public Titulo? Titulo { get; set; }

    }
}
