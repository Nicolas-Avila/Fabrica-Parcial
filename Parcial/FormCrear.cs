using System;
using System.Windows.Forms;
using Trabajador;
using static Parcial.Inicio;

namespace Parcial
{
    public partial class FormCrear : Form
    {
        CambiarColor cambiarColor;

        public FormCrear(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
        }

        private void CrearSillas_Click(object sender, EventArgs e)
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
                    SillaMadera.CrearSillaMadera(silla);
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
                    SillaMetal.CrearSillaMetal(silla);
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }

        }

        private void CrearMesa_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;
            

            foreach (Control item in mesas.Controls)//Controls es el groupbox
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }

            if (mesa == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico"))
                {
                    MesaDeMadera.CrearMesaMadera(mesa);
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            } 
            if (mesa == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico"))
                {
                    MesaMetal.CrearMesaMetal(mesa);
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }
        }

        private void CrearTodo_Click(object sender, EventArgs e)
        {

            string mesa = this.mesas.Text;
            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            MesaMetal.CrearMesaMetal(mesa);
            //MesaMadera.CrearMesaMadera(mesa);


            string silla = this.sillas.Text;
            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }
            }
            SillaMadera.CrearSillaMadera(silla);
            SillaMetal.CrearSillaMetal(silla);
        }

        private void VerMaterial_Click(object sender, EventArgs e)
        {

            Material mostrar = new Material(cambiarColor);
            mostrar.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

            Close();
        }

    }
}
