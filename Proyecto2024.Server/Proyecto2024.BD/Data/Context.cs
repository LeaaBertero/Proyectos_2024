﻿using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data
{
    public class Context : DbContext
    {
        //acá van las tablas de la base de datos
        public DbSet<TDocumento> TDocumentos { get; set; }

        public DbSet<Persona> Persona { get; set; }


        //constructor del context
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
