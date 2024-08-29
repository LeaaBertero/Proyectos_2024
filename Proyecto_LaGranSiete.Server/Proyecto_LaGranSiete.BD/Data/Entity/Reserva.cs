using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    
    


    public class Reserva : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int ReservaId { get; set; }

        //Clave foranea de la tabla (Usuarios)

        public int UsuarioId { get; set; }

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------


        //----------------------------------------------------
       
        //[MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime FechaHoraReserva { get; set; }


       
        
        public int DuracionAlquiler { get; set; }

        
       
        public double Monto { get; set; }

        
      
        //[MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string MetodoPago { get; set; } 

        
        
        //[MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string EstadoReserva { get; set; }

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Partidos)



        //(Clave primaria de la tabla (Pagos) que se relaciona con la tabla (Reservas))


        //---------------------------------------------------------
        //Relacion entre tablas

      

        public int EquipoId { get; set; }
        public Equipo Equipos { get; set; }

        public int PagoId { get; set; }
        public Pago Pagos { get; set; }

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }
        //---------------------------------------------------------






        //--------------------------------------------------------


        //Lista de los usuarios que realizan reservas
        //--Renueva la lista por cada usuario que realice una reserva
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        //Lista de los usuarios que realizaron reservas
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        
        //Tabla lista
    }
}

       




