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

    public partial class FormRellenar : Form
    {
        protected CambiarColor cambiarColor;
        public FormRellenar(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
        }

        private void añadir_Click(object sender, EventArgs e)

        {
            Inventario inventario = new Inventario ();

            int cantTela = (int)this.numericUpDown1.Value;
            int cantMetal = (int)this.numericUpDown2.Value;
            int cantMadera = (int)this.numericUpDown3.Value;
            int cantPlastico = (int)this.numericUpDown4.Value;

            foreach (string material in inventario.Stock.Keys)
            {
                if (material == "madera")
                {
                    inventario.Stock[material] += cantMadera;
                }
                else if (material == "tela")
                {
                    inventario.Stock[material] += cantTela;
                }
                else if (material == "plastico")
                {
                    inventario.Stock[material] += cantPlastico;
                }
                else if (material == "metal")
                {
                    inventario.Stock[material] += cantMetal;
                    
                }
            }
            string mensaje = $"Cantidad de tela: {cantTela.ToString()}\n" +
                $"Cantidad de metal: {cantMetal.ToString()}\n" +
                $"Cantidad de madera: {cantMadera.ToString()}\n" +
                $"Cantidad de plástico: {cantPlastico.ToString()}";
            MessageBox.Show(mensaje);
        }


    }
}
