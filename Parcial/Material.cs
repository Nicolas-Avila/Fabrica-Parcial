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
    public partial class Material : Form
    {
        protected CambiarColor cambiarColor;
        Inventario inventario = new Inventario();
        public Material(CambiarColor cambiarColor)
        {
            InitializeComponent();
            
            var materialesOrdenados = inventario.Stock.Select(item => new { Componente = item.Key, Cantidad = item.Value }).ToList();
            materialesOrdenados.Sort((material1, material2) => material1.Cantidad - material2.Cantidad);
            dataGridView1.DataSource = materialesOrdenados;
            this.cambiarColor = cambiarColor;
            cambiarColor(this);

        }


        private void listaMaterial_Click(object sender, EventArgs e)
        {
            List<ItemStock> listaStock = inventario.Stock.Select(item => new ItemStock { Componente = item.Key, Cantidad = item.Value }).ToList();
            Archivos<List<ItemStock>> listas = new Archivos<List<ItemStock>>();
            listas.crearXml(listaStock);
            MessageBox.Show("Lista Creada");

        }
        public class ItemStock
        {
            public string Componente { get; set; }
            public int Cantidad { get; set; }
        }

    }
}

