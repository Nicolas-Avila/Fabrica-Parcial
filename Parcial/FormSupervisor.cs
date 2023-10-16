using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormSupervisor : Form
    {

        private Inicio formularioInicio;

        public FormSupervisor(Inicio formularioInicio)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;

        }

        private void FormSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarOperario mostrarOperario = new MostrarOperario();

            Hide();
            DialogResult result = mostrarOperario.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRellenar rellenar = new FormRellenar();
            Hide();
            DialogResult result = rellenar.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCrear formOperador = new FormCrear();

            Hide();
            DialogResult result = formOperador.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Material mostrar = new Material();
            mostrar.Show();
        }
    }
}
