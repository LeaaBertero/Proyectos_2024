using Microsoft.EntityFrameworkCore;
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
        //agregar tablas //DbSet --> es de la misma clase que DbContext
        public DbSet<TDocumento> TDocumento { get; set; }
        public DbSet<TDocumento> Personas { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
