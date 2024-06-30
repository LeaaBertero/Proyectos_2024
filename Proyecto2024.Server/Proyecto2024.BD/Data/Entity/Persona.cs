using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //indices (restricciones para el usuario, como mensaje, para que sepa que es lo que debe
    //poner como dato para ingresar al sistema y asi evitar que pong cualquier dato)
    [Index(nameof(TDocumentoID), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]

    //-------------------------------------- IMPORTANTE -------------------------------------------------
    
    //En este lugar en la carpeta de las entidades, se hacen todas las clases, referidas a las entidades
    //y en el context, se hacen las tablas, post haber hecho las entidades en éste lugar    

    //-------------------------------------- IMPORTANTE -------------------------------------------------
    public class Persona : EntityBase
    {
        //mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        [MaxLength(12, ErrorMessage = "Máximo de número de caracteres {1}.")]
        public string? NumDoc { get; set; }
        

        
        //Mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "El nombre de la persona es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo de número de caracteres {1}.")]
        public string? Nombre { get; set; }
        

        
        //mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "El apellido de la persona es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo de número de caracteres {1}.")]
        public string? Apellido { get; set; }



        //mensajes para el usuario, emitidos desde el backend hacia el frontEnd(Parte visual)
        [Required(ErrorMessage = "El tipo de documento es obligatorio")]
        public int TDocumentoID { get; set; }

        
        
        //Ésta es una propiedad que se relaciona a la persona,
        //es decir la clase (TDocumento como objeto y la propiedad del objeto en si..)
        public TDocumento? TDocumento {get; set;}

        //Lista de personas en la clase persona
        public List<Profesion>? Profesiones { get; set; }
    }
}
