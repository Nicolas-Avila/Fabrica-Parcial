using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajador;
using static Parcial.Inicio;

namespace Parcial
{
    public partial class Productos : Form
    {
        protected CambiarColor cambiarColor;
        public Productos(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
            dataGridView1.DataSource = Inventario.ProductosMMadera;
            dataGridView2.DataSource = Inventario.ProductosMMetal;
            dataGridView3.DataSource = Inventario.ProductosSMadera;
            dataGridView4.DataSource = Inventario.ProductoSMetal;
        }


    }
}
