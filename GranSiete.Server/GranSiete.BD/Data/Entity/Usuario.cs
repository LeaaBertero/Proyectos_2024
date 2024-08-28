using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranSiete.BD.Data.Entity
{
    public class Usuario : EntityBase
    {   //----------------------------
        //clave primaria de la tabla
        //----------------------------
        public int UsuarioID { get; set; }
        
        
        //-----------------------
        //Atributos de la tabla
        //-----------------------
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        public int Telefono { get; set; }
        public string? CorreoElectronico { get; set; }

        public string? Parentesco { get; set; }
        //-----------------------
        //Atributos de la tabla
        //-----------------------
    }
}
