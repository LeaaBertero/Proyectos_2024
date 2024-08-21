using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class EquipoUno : EntityBase
    {
        //--------------------------------------------
        //Clave primaria de la tabla
        public int EquipoUnoId { get; set; }
        //--------------------------------------------
 
        //Atributos de la tabla
        public string? NombreEquipoUno { get; set; }
        //--------------------------------------------

        //Clave foránea de la tabla
        public int ReservaId { get; set; }

        //Relacion de tablas con otrs tablas
        public Reserva? Reserva { get; set; }
        

        public List<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
