using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //Indices
    [Index(nameof(Codigo), Name = "Titulo_UQ", IsUnique = true)]

    //clase titulo que hereda de entityBase que tiene un Id, para todas las entidades de la base de datos
    public class Titulo : EntityBase
    {   //importante: el REQUIRED: son mensajes que se le envia al usuario desde el back-end hacia el front-end
        [Required(ErrorMessage = "El código del título es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1} ")]
        public string Codigo { get; set; }


        [Required(ErrorMessage = "El nombre del título es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1} ")]
        public string Nombre { get; set; }

        //Lista de profesiones
        public List<Profesion> Profesiones { get; set; } //lista de profesiones, por que son mas de una
    }
}
