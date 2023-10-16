using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class MostrarOperario : Form
    {
        public MostrarOperario()
        {
            InitializeComponent();
            cuadroOperario.DataSource = Listas.IniciosOperario;
            dataGridView1.DataSource = Inventario.ProductosMMadera;
            dataGridView2.DataSource = Inventario.ProductosMMetal;
            dataGridView3.DataSource = Inventario.ProductosSMadera;
            dataGridView4.DataSource = Inventario.ProductoSMetal;

        }




    }
}
