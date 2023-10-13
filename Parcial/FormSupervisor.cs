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
            mostrarOperario.Show();

        }
    }
}
