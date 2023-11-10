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

        private void listaMaterial_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Inventario.Stock)
            {
                sb.AppendLine($"{item.Key}: {item.Value}");
            }
            string datos = sb.ToString();

            Archivos.crearArchivo("Stock", "xml", datos);
            MessageBox.Show("Lista Creada");
        }

    }
}

