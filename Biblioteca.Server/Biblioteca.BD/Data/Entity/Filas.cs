using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BD.Data.Entity
{
    public class Filas : EntityBase
    {
        //clave primaria de la tabla
        public int IdFilas { get; set; }

        //-------------------------------
        //propiedades o atributos de la tabla
        public int FilaNumero { get; set; }
    }
}
