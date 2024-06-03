using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //clase publica *//* Productos *//*
    public class Producto
    {
        #region atributos
        // --* Atributos de la clase Producto *-- //
        private int codigo;
        
        private string descripcion;
        
        private int stock;

        #endregion

        #region constructores
        public Producto()
        {

        }

        public Producto(int cod, string Desc) 
        {
            codigo = cod;

            descripcion = Desc;

            stock = 0;
        }
        #endregion

        #region Métodos
        public void Ingreso(int cant) 
        {
            stock = stock + cant;
        }

        public void Salida(int cant)
        {
            stock = stock - cant;
        }
        #endregion

    }
}

