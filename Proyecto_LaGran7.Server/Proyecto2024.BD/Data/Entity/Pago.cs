using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data.Entity
{
    public class Pago : EntityBase
    {
        public int IdReserva { get; set; }
        public int Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public string? metodoPago { get; set; }
    }
}
