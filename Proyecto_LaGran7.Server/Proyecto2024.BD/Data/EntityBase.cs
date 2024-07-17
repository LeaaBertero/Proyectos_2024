using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaGran7.BD.Data
{
    //Clase EntidadBase que se hereda de todas las entidades(tablas) que estan en la base de datos
    public class EntityBase //Entidad ID Base, para todas las tablas de la base de datos
    {
        //clase generada con un (id), para heredarla en cada una de las tablas del proyecto 
        public int ID { get; set; } 
    }
}
