using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class EquipoDos : EntityBase
    {
        //--------------------------------
        //Clave primaria de la tabla
        //--------------------------------
        public int EquipoDosId { get; set; }

        //--------------------------------
        //Clave foránea de la tabla
        //--------------------------------
        public int ReservaID { get; set; }
        

        public int UsuarioID { get; set; }
        
        //--------------------------------
        //Atributos de la tabla
        //--------------------------------
        public string? NombreEquipoDos { get; set; }
    
    }
}
