using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    [Index(nameof(Codigo), Name = "Titulo_UQ", IsUnique = true)]
    public class Titulo : EntityBase
    {
        //Mensaje para el dato del Código
        //Mensaje para el usuario desde el backEnd hacia el frontEnd
        [Required(ErrorMessage = "El código del titulo es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Codigo { get; set; }



        //Mensaje para el dato del Nombre
        //Mensaje para el usuario desde el backend hacia el frontEnd
        [Required(ErrorMessage = "El nombre del titulo es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string? Nombre { get; set; }

        public List<Profesion>? Proofesiones { get; set; }

    }
}
