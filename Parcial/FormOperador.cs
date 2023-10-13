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
    public partial class FormOperador : Form
    {
        private Inicio formularioInicio;

        public FormOperador(Inicio formularioInicio)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;
        }

        private void FormOperador_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show(); // Muestra el formulario de inicio
        }

    }
}
