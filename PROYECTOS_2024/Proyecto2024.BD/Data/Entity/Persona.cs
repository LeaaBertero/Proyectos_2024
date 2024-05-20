using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //para unificar los Id hacer un index
    [Index(nameof(TDocumentoId), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]

    public class Persona : EntityBase
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

    }
}
