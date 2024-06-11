using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    //etiquetas para organizar los indices
    [Index(nameof(Codigo), Name = "TDocumento_UQ", IsUnique = true)]

    //clase TDocumento que hereda de EntityBase, clase que contiene un id, para todas las clases 
    public class TDocumento : EntityBase //clase - herencia
    {

        [Required(ErrorMessage = "El código del tipo de documento es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1} ")]
        
        //propiedad de la clase TDocumento (Codigo)
        public string Codigo { get; set; }


        [Required(ErrorMessage = "El nombre del tipo de documento es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1} ")]
        
        //propiedad de la clase TDocumento (Nombre)
        public string Nombre { get; set;}

        public List<Persona> Personas { get; set; }

    }
}
