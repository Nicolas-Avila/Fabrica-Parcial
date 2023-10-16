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
    public partial class FormOperadores : Form
    {

        private Inicio formularioInicio;
        public FormOperadores(Inicio formularioInicio)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;
        }

        private void FormOperadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            string silla = this.sillas.Text;

            FormProcesando formProcesando = new FormProcesando();

            formProcesando.Show();
            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }

            }
            if (silla == "Silla de madera")
            {
                SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                Inventario.ProductosSMadera.Add(sillaMadera);
                Inventario.StockMateriales("madera", "tela");

            }
            if (silla == "Silla de metal")
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                Inventario.ProductoSMetal.Add(sillaMetal);
                Inventario.StockMateriales("metal", "tela");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;
            FormProcesando formProcesando = new FormProcesando();

            formProcesando.Show();

            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            if (mesa == "Mesa de metal")
            {
                MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                Inventario.ProductosMMetal.Add(mesaMetal);
                Inventario.StockMateriales("metal", "plastico");
            }

            if (mesa == "Mesa de madera")
            {
                MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                Inventario.ProductosMMadera.Add(mesaMadera);
                Inventario.StockMateriales("madera", "plastico");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;
            FormProcesando formProcesando = new FormProcesando();

            formProcesando.Show();

            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            if (mesa == "Mesa de metal")
            {
                MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                Inventario.ProductosMMetal.Add(mesaMetal);
                Inventario.StockMateriales("metal", "plastico");
            }

            if (mesa == "Mesa de madera")
            {
                MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                Inventario.ProductosMMadera.Add(mesaMadera);
                Inventario.StockMateriales("madera", "plastico");
            }

            string silla = this.sillas.Text;

            formProcesando.Show();
            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }

            }
            if (silla == "Silla de madera")
            {
                SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                Inventario.ProductosSMadera.Add(sillaMadera);
                Inventario.StockMateriales("madera", "tela");
            }
            if (silla == "Silla de metal")
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                Inventario.ProductoSMetal.Add(sillaMetal);
                Inventario.StockMateriales("metal", "tela");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Material mostrar = new Material();
            mostrar.Show();
        }
    }
}
