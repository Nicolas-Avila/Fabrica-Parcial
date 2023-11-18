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
        private Inventario inventario;

        public Productos(CambiarColor cambiarColor)
        {
            // Corrige esta línea para asignar el valor a la variable de instancia, no declarar una nueva variable
            this.inventario = new Inventario();

            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
            dataGridView1.DataSource = inventario.ProductosMMadera;
            dataGridView2.DataSource = inventario.ProductosMMetal;
            dataGridView3.DataSource = inventario.ProductosSMadera;
            dataGridView4.DataSource = inventario.ProductoSMetal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ahora puedes acceder a la variable de instancia correctamente
            Console.WriteLine("HOLAA");
            foreach (var item in inventario.ProductosMMadera)
            {
            }
        }
    }
}
