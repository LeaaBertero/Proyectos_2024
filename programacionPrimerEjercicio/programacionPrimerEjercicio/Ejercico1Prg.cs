using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace programacionPrimerEjercicio
{
    public partial class Ejercico1Prg : Form
    {
        public Ejercico1Prg()
        {
            InitializeComponent();
        }

        //boton para salir del formulario con un click
        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            //Producto producto = 
            //producto = new Producto();

            Producto producto = new Producto(int.Parse(txCodigo.Text), txDescripcion.Text);

            MessageBox.Show("Producto cargado !!");
        }
    }
}
