using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lagran7.BD.Data
{
    public class Context : DbContext
    {
        //constructor
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
