using Fabrica;
using System;
using System.Windows.Forms;
using static Parcial.Inicio;

namespace Parcial
{
    public partial class FormRellenar : Form
    {
        protected CambiarColor cambiarColor;
        private Newsletter newsletter;

        public FormRellenar(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;

            // Crea una nueva instancia de Newsletter
            this.newsletter = new Newsletter("Agregado con Exito");
            // Suscribor al evento NovedadEnviada
            newsletter.NovedadEnviada += MostrarMensajeNovedad;

            cambiarColor(this);
        }
        
        private void añadir_Click(object sender, EventArgs e)
        {
            int cantTela = (int)this.numericUpDown1.Value;
            int cantMetal = (int)this.numericUpDown2.Value;
            int cantMadera = (int)this.numericUpDown3.Value;
            int cantPlastico = (int)this.numericUpDown4.Value;

            foreach (string material in Inventario.Stock.Keys)
            {
                if (material == "madera")
                {
                    Inventario.Stock[material] += cantMadera;
                }
                else if (material == "tela")
                {
                    Inventario.Stock[material] += cantTela;
                }
                else if (material == "plastico")
                {
                    Inventario.Stock[material] += cantPlastico;
                }
                else if (material == "metal")
                {
                    Inventario.Stock[material] += cantMetal;
                }
            }

            
            newsletter.EnviarNovedades();
        }

        // Método para manejar el evento NovedadEnviada
        private void MostrarMensajeNovedad(Newsletter sender, string mensaje)
        {
            // Mostrar un MessageBox con la información
            MessageBox.Show(mensaje, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
