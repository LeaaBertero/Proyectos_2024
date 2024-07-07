using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    //(Indices de la tabla (Cancha))
    [Index(nameof(IdCancha), Name = "Cancha_UQ", IsUnique = true)]
    [Index(nameof(Nombre), nameof(Ubicaciòn), nameof(Estado), Name = "Nombre_Ubicación_Estado", IsUnique = false)]

    public class Cancha : EntityBase
    {
        //Clave primaria de la tabla (Cancha)
        [Required(ErrorMessage = "El Número de cancha es obligatorio")]
        [MaxLength(2, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdCancha { get; set; }



        //----------------------------------------------------------------
        //Atributos
        //----------------------------------------------------------------



        //Atributos de la tabla (Cancha)
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }




        //Atributos de la tabla_(Cancha)
        [Required(ErrorMessage = "La seleccion de cancha es obligatoria")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Ubicaciòn { get; set; } //Ubicacion del predio(Dirección -  (Complejo deportivo La Gran 7))




        //Aributo de la tabla (Cancha)
        [Required(ErrorMessage = "El estado de la cancha es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Estado { get; set; }
    }
}



