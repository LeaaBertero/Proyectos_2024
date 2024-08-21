﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(EquipoId), Name = "IdEquipos", IsUnique = true)]
    [Index(nameof(NombreEquipos), nameof(Integrantes),
    Name = "NombreEquipos_Integrantes", IsUnique = false)]

    public class Equipo : EntityBase
    {
        //Clave primaria de la tabla
        public int IdEquipos { get; set; }
        
                                                            

        //-------------------------------------------------------
        //Propiedades de la tabla
        //-------------------------------------------------------

        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreEquipos { get; set; }
        //-------------------------------------------------------
        //cantidad de integrantes que conforman el equipo
        //-------------------------------------------------------

        [Required(ErrorMessage = "El campo integrantes es obligatorio (especificar en número), máximo por equipo 7 personas")]
        [MaxLength(7, ErrorMessage = "Máximo de jugadores por equipo")]
        public int Integrantes { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------
       
        
        //Partidos
        public int EquipoId { get; set; }
        public Equipo? Equipos { get; set; }

        //Canchas
        public int CanchasId { get; set; }
        public Cancha? Canchas { get; set; }

        //Pagos
        public int PagoId { get; set; }
        public Pago? Pagos { get; set; }

        
        //--------------------------------------------------------
    }
}


