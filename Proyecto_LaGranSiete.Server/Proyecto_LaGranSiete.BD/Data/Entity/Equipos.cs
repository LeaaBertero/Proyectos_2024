using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(IdEquipos), Name = "IdEquipos", IsUnique = true)]
    [Index(nameof(NombreEquipos), nameof(Integrantes),
    Name = "NombreEquipos_Integrantes", IsUnique = false)]

    public class Equipos : EntityBase
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

        [Required(ErrorMessage = "Los integrantes del equipo son obligatorios")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
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


