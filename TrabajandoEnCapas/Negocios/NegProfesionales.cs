using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegProfesionales
    {
        DatosProfesionales objDatosProfes = new DatosProfesionales();

        public int abmProfesionales(string accion, Profesional objProfesional)
        {
            return objDatosProfes.abmProfesionales(accion, objProfesional);
        }

        public DataSet listadoProfesionales(string cual)
        {
            return objDatosProfes.listadoProfesionales(cual);
        }
    }
}
