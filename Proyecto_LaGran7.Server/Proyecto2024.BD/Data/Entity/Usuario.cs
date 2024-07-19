using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    public class Usuario : EntityBase
    {
        //------------------------------------------
        //Clave primaria (PK) de la tabla Usuarios
        public int IdUsuario { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Atributos de la tabla (Usuarios)
        //------------------------------------------

        //------------------------------------------
        //Atributos de la tabla Usuario
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }
        //------------------------------------------


        //------------------------------------------
        //Atributos de la tabla Usuario
        [Required(ErrorMessage = "El E-mail es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Mail { get; set; }
        //------------------------------------------


        //------------------------------------------
        //Atributos de la tabla Usuario
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(180, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Contraseña { get; set; }
        //------------------------------------------



        //------------------------------------------
        //Atributos de la tabla usuario
        [Required(ErrorMessage = "El rol es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Rol { get; set; }
        //------------------------------------------



        //------------------------------------------
        //RELACIONES ENTRE TABLAS
        //------------------------------------------


        //------------------------------------------
        //Tablas que se relacionan con los Id de otras tablas
        //------------------------------------------

        //------------------------------------------
        //Tabla (Pago) que se relaciona con tabla (Usuarios)
        public Pago? Pago { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria (PK) de la tabla (Pagos)
        public int IdPago { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Tabla Reserva que se encuentra en el Context(Base de datos), que se relaciona con la tabla Usuarios
        public Reserva? Reserva { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria de la tabla (Reserva)
        public int IdReserva { get; set; }
        //------------------------------------------

        //------------------------------------------
        //Clave primaria de la tabla Cancha
        //public int IdCancha { get; set; }
        //------------------------------------------
    }
}

      

