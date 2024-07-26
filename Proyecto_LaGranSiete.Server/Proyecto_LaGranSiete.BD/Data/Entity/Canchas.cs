using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Canchas : EntityBase
    {
        //clave primaria de la tabla 
        public int IdCanchas { get; set; }

        //Identificacion de la cancha para el usuario que realiza la reserva

        //----------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------
        public string? NombreCancha { get; set; }

        //Disponibilidad para el usuario (si / no)
        public bool? Disponibilidad { get; set; }
    }
}



