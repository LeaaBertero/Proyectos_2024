using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //para unificar los Id hacer un index O INDICE EN RELACION AL ORDEN QUE SE VA A MOSTRAR EN EL FRONTEND
    [Index(nameof(TDocumentoId), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]


    //ÉN ESTA SECCIÓN VAN LAS ENTIDADES DE LA BASE DE DATOS
    public class Persona : EntityBase //HEREDA DE ENTITY BASE -  POR QUE ENTITY BASE TIENE UN ID ,
                                      //POR QUE TODAS LAS TABLAS TIENEN UN ID Y AL HEREDAR LA CLASE ENTITY BASE, HEREDAN TODOS LAS DEMAS ENTIDADES
    {
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        [MaxLength(12, ErrorMessage = "Máximo número de caracteres {1} ")]
        public string NumDoc { get; set; }


        [Required(ErrorMessage = "El nombre de la persona es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1} ")]
        public string Nombre { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1} ")]
        [Required(ErrorMessage = "El apellido de la persona es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El tipo de documento es obligatorio")]
        public int TDocumentoId { get; set; }

        public TDocumento TDocumento { get; set;}

        public List<Profesion> profesiones { get; set; }

    }
}
