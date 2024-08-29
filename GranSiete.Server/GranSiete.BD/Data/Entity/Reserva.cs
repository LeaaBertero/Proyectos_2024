using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    //indices de la tabla
    [Index(nameof(UsuarioID), nameof(EstadoReserva), Name = "Reserva_UQ", IsUnique = true)]
    [Index(nameof(Monto), nameof(MetodoPago), nameof(EstadoReserva), Name = "Reserva_Monto_MetodoPago_EstadoReserva", IsUnique = false)]

    public class Reserva : EntityBase
    {
        //-----------------------------
        //Clave primaria de la tabla
        //-----------------------------
       
        public int ReservaId { get; set; }
        
        //Tabla relacionada
        


        //-----------------------------
        //Clave foránea de la tabla
        //-----------------------------
        public int UsuarioID { get; set; }



        //-----------------------
        //Atributos de la tabla
        //-----------------------
        public DateTime? FechaHoraReserva { get; set; }
        public DateTime? DuracionAlquiler { get; set; }
        public int Monto { get; set; }

        public string? MetodoPago { get; set; }

        public string? EstadoReserva { get; set; }
        //-----------------------
        //Atributos de la tabla
        //-----------------------
    }
}
