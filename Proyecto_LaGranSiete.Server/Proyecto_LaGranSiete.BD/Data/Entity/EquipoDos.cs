using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class EquipoDos : EntityBase
    {   //----------------------------------------------
        //Clave primaria de la tabla
        public int EquipoDosId { get; set; }

        //----------------------------------------------
        //atributos de la tabla
        public string? NombreEquipoDos { get; set; }
        
        //----------------------------------------------
        //Clave foranea de la tabla
        public int ReservaId { get; set; }

        //Relaciones entre tablas
        public Reserva? Reservas { get; set; }


        public List<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
