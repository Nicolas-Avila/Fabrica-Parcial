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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
            dataGridView1.DataSource = Inventario.Stock.Select(item => new { Componente = item.Key, Cantidad = item.Value }).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
