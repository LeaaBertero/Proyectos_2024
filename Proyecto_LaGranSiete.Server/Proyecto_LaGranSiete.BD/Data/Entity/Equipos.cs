﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    public class Equipos : EntityBase
    {
        //Clave primaria de la tabla
        public int IdEquipos { get; set; }

        //-------------------------------------------------------
        //Propiedades de la tabla
        //-------------------------------------------------------
        public string? NombreEquipos { get; set; }
        //-------------------------------------------------------
        //cantidad de integrantes que conforman el equipo
        //-------------------------------------------------------

        public int Integrantes { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
        public int PartidosId { get; set; }
        public Partidos? Partidos { get; set; }
        //--------------------------------------------------------


    }
}
