using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesional
    {
        private int codProf;
        private string nombre;

        public Profesional()
        {
            codProf = 0;
            nombre = string.Empty;
        }

        public int CodProf
        {
            get { return codProf; }
            set { codProf = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
