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
    public partial class FormRellenar : Form
    {
        public FormRellenar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantTela = (int)this.numericUpDown1.Value;
            int cantMetal = (int)this.numericUpDown2.Value;
            int cantMadera = (int)this.numericUpDown3.Value;
            int cantPlastico = (int)this.numericUpDown4.Value;

            foreach (string material in Inventario.Stock.Keys)
            {
                if(material == "madera")
                {
                    Inventario.Stock[material] += cantMadera;
                }
                else if (material == "tela")
                {
                    Inventario.Stock[material] += cantTela;
                }
                else if(material == "plastico")
                {
                    Inventario.Stock[material] += cantPlastico;
                }
                else if(material == "metal")
                {
                    Inventario.Stock[material] += cantMetal;
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
