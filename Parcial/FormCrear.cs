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
    public partial class FormCrear : Form
    {



        public FormCrear()
        {
            InitializeComponent();

        }

        private void FormOperadores_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            string silla = this.sillas.Text;

            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }

            }
            if (silla == "Silla de madera")
            {

                if (Inventario.VerificarStock("madera", "tela"))
                {
                    SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                    Inventario.ProductosSMadera.Add(sillaMadera);
                    Inventario.StockMateriales("madera", "tela");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();

                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }
            if (silla == "Silla de metal")
            {
                if (Inventario.VerificarStock("metal", "tela"))
                {
                    SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                    Inventario.ProductoSMetal.Add(sillaMetal);
                    Inventario.StockMateriales("metal", "tela");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;


            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            if (mesa == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico"))
                {
                    MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                    Inventario.ProductosMMetal.Add(mesaMetal);
                    Inventario.StockMateriales("metal", "plastico");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

            if (mesa == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico"))
                {
                    MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                    Inventario.ProductosMMadera.Add(mesaMadera);
                    Inventario.StockMateriales("madera", "plastico");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;


            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            if (mesa == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico"))
                {
                    MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                    Inventario.ProductosMMetal.Add(mesaMetal);
                    Inventario.StockMateriales("metal", "plastico");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

            if (mesa == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico"))
                {
                    MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                    Inventario.ProductosMMadera.Add(mesaMadera);
                    Inventario.StockMateriales("madera", "plastico");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

            string silla = this.sillas.Text;

            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }

            }
            if (silla == "Silla de madera")
            {
                if (Inventario.VerificarStock("madera", "tela"))
                {
                    SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                    Inventario.ProductosSMadera.Add(sillaMadera);
                    Inventario.StockMateriales("madera", "tela");
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }
            if (silla == "Silla de metal")
            {
                if (Inventario.VerificarStock("metal", "tela"))
                {
                    SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                    Inventario.ProductoSMetal.Add(sillaMetal);
                    Inventario.StockMateriales("metal", "tela");
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Material mostrar = new Material();
            mostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
