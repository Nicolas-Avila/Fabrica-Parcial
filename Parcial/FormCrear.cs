using System;
using System.Windows.Forms;
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
            SillaMadera sillaMadera = new SillaMadera("","");
            bool resultadoSillaMadera = sillaMadera.CrearProducto(silla);
            SillaMetal sillaMetal = new SillaMetal("", "");
            bool resultadoSillaMetal = sillaMetal.CrearProducto(silla);
            if (resultadoSillaMadera || resultadoSillaMetal)
            {
                 FormProcesando formProcesando = new FormProcesando();
                 formProcesando.Show();                
            }
            else
            {
                MessageBox.Show("Falta de stock");
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
            MesaDeMadera mesaDeMadera = new MesaDeMadera("", "");
            bool resultadoMesaDeMadera = mesaDeMadera.CrearProducto(mesa);
            MesaMetal mesaMetal = new MesaMetal("", "");
            bool resultadoMesaMetal = mesaMetal.CrearProducto(mesa);
            if (resultadoMesaDeMadera || resultadoMesaMetal)
            {
                FormProcesando formProcesando = new FormProcesando();
                formProcesando.Show();
            }
            else
            {
                MessageBox.Show("Falta de stock");
            }            
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
