using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    //Indices para la clave primaria
    [Index(nameof(IdUsuario), Name = "UsuarioId_UQ", IsUnique = true)]
    //Indices para los atributos de las tablas
    [Index(nameof(Nombre), nameof(Mail), nameof(Contraseña), nameof(Rol), Name = "Persona_Nombre_Mail_Rol", IsUnique = false)]

    public class Usuarios : EntityBase
    {
        //---------------------------------------------------------------------
        //Clave primaria de la tabla (Pago)
        public int IdPago { get; set; }
        
        //Tabla (Pago) - Que se relaciona con tabla (Usuarios)
        public Pago? Pago { get; set; }
        //---------------------------------------------------------------------


        //Relacion con tabla Reserva
        //Clave primaria de la tabla
        [Required(ErrorMessage = "Ingrese su Id de usuario (4 dígitos)")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdUsuario { get; set; }

        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        
        //Tabla Reserva
        //Tabla (Reserva), que se relaciona con la tabla Usuarios - (De uno a muchos)
        public Reserva? Reserva { get; set; }


        //Clave primaria de la taabla (Reserva), que establece conexion con la tabla Usuarios por medio de la clave primaria
        //----------------------------------------------------------------------------------------
        //Relaciones entre tablas (Por medio de la PK de laa tabla Reserva)
        //-----------------------------------------------------------------------------------------
        [Required(ErrorMessage = "El número de reserva es obligatorio")]
        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}")]
        public int IdReserva { get; set; } //PK - (Clave primaria) de la tabla Reserva que se relaciona con la tabla Usuarios

        //-----------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        //Atributos de la tabla (Usuarios)
        //--------------------------------------------------------------------------------


        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El nombre es obligatorio")] //Mensaje para el usuario
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")] //Para el frontEnd
        public string? Nombre { get; set; } //Atributos de la tabla


            
        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El E-mail es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Mail { get; set; }



        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(180, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Contraseña { get; set; }



        //Atributo de la tabla(Usuarios)
        [Required(ErrorMessage = "El rol es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Rol { get; set; } // Rol(Cliente(Usuario) - (Administrador), (Administrador del sistema))


        //Lista de Usuario que realizaron una o muchas reservas
        public List<Reserva>? Resrva { get; set; }
    }
}
        

        
       
       



        
