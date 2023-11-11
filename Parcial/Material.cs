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
            List<ItemStock> listaStock = Inventario.Stock.Select(item => new ItemStock { Componente = item.Key, Cantidad = item.Value }).ToList();
            Archivos<List<ItemStock>>.crearXml(listaStock);
            MessageBox.Show("Lista Creada");

        }
        public class ItemStock
        {
            public string Componente { get; set; }
            public int Cantidad { get; set; }
        }

    }
}

