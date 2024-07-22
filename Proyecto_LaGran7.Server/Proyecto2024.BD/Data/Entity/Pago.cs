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
    //atributos de las tablas (No son claves unicas)
    [Index(nameof(Monto), nameof(FechaPago), nameof(metodoPago), Name = "Monto_FechaPago_MétodoPago", IsUnique = false)]

    public class Pago : EntityBase
    {
        //------------------------------------------
        //Clave primaria de la tabla (Pago)
        public int IdPago { get; set; }
        //------------------------------------------


        //------------------------------------------
        //Tabla (Cancha), que se relaciona con Tabla (Pago)
        public Cancha? Cancha { get; set; }
        //------------------------------------------



        //------------------------------------------
        //Clave primaria del la tabla (Cancha) que se relaciona con la tabla (Pago)
        public int IdCancha { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Tabla (Reserva), que se relaciona con tabla (Pago)
        //public Reserva? Reservas { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria de la tabla Reserva
        public int IdReserva { get; set; }
        //------------------------------------------




        //------------------------------------------
        //Atributo de la tabla (Pagos)
        //------------------------------------------

        [Required(ErrorMessage = "Ingrese el monto a abonar")]
        [MaxLength(12, ErrorMessage = "Máximo número de caracteres {1}")]
        //cantidad que debe abonar por el alquiler de la cancha
        public decimal Monto { get; set; }





        //------------------------------------------
        //Atributo de la tabla (Pagos)
        //------------------------------------------

        [Required(ErrorMessage = "Fecha de la reserva")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        //Fecha en la que se abona el alquiler de la cancha
        public DateTime? FechaPago { get; set; }



        //------------------------------------------
        //Atributo de la tabla (Pagos)
        //------------------------------------------

        [Required(ErrorMessage = "Método de pago")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]

       
        //METODO DE PAGOOOOOOOOOO !!!!!!!!!
        public string? metodoPago { get; set; } //usuario debe ingresar el método para abonar
        //Si el usuario va a abonar on-line o pago presencial (En el predio),
        //para realizar el alquiler de la cancha
       

        //Lista que se actualiza a medida que los usuarios van realizando
        //el pago por el alquiler de las canchas

        //public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

    }
}





       

        




      

        
        










       

        
        






       





        
        

        
        

