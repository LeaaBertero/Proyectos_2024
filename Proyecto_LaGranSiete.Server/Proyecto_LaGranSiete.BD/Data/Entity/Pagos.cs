using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(IdPago), Name = "IdPago", IsUnique = true)]
    [Index(nameof(Monto_Pago), nameof(FechaPago),
    Name = "Monto_Pago_FechaPago", IsUnique = false)]

    public class Pagos : EntityBase
    {
        //Clave primaria de la tabla
        public int IdPago { get; set; }

        //clave foranea de la tabla Reserva
        public int IdReserva { get; set; }

        //------------------------------------------------------
        //Propiedades de la tabla
        //------------------------------------------------------

        [Required(ErrorMessage = "El monto es obligatorio")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public float? Monto_Pago { get; set; }

        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly FechaPago { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int CanchasId { get; set; }
        public Canchas? Canchas { get; set; }
        //--------------------------------------------------------
    }
}
