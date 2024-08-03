using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearReservaDTO
    {
        public DateTime FechaHoraReserva { get; set; }
        public DateTime DuracionAlquiler { get; set; }
        public float Monto { get; set; }
        public string? MetodoPago { get; set; }
        public string? EstadoReserva { get; set; }
    }
}
       


        


       


       


       
