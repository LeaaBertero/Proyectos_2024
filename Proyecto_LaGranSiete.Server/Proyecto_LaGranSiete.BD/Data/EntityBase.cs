using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data
{
    //Con presionar (Control + .), se despliega una lista de opciones, en la cual,
    //se debe seleccionar "Extraer Interfaz" y presionamos en Aceptar, 
    //dónde vamos a obtener la herencia de (EntityBase), IEntityBase 
    public class EntityBase : IEntityBase
    {
        //Id de cada una de las tablas
        public int Id { get; set; }
    }
}
