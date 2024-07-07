using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoLaGran7.BD.Data.Entity
{
    //Indices
    [Index(nameof(IdPago), Name = "IdPago_UQ", IsUnique = true)]
    [Index(nameof(Monto), nameof(FechaPago), nameof(metodoPago), Name = "Monto_FechaPago_MétodoPago", IsUnique = false)]

    
    public class Pago : EntityBase
    {
        //---------------------------------------------------------------
        //Clave primaria
        //---------------------------------------------------------------
        
        //PK - (Clave primaria de la tabla PAGO)
        [Required(ErrorMessage = "El campo Id_Pago es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdPago { get; set; }




        //---------------------------------------------------------------
        //Clave foránea
        //---------------------------------------------------------------
        
        //FK - (Clave foránea de la tabla PAGO)
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdReserva { get; set; }



        
        //---------------------------------------------------------------
        //Atributos de la tabla (Pago)
        //---------------------------------------------------------------

        //Atributo de la tabla
        [Required(ErrorMessage = "Debe ingresa el monto")]
        [MaxLength(12, ErrorMessage = "Máximo número de caracteres {1}")]
        public int Monto { get; set; }




        //Atributo de la tabla
        [Required(ErrorMessage = "Indique la fecha de la reserva")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? FechaPago { get; set; }

        
        
        //Atributo de la tabla
        [Required(ErrorMessage = "Indique el método de pago")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? metodoPago { get; set; }
    }
}

        
        

        
        

