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
using Trabajador;
using Fabrica;
using static Parcial.Inicio;

namespace Parcial
{
    public partial class FormSupervisor : Form
    {
        private Inicio formularioInicio;
        protected CambiarColor cambiarColor;
        public FormSupervisor(Inicio formularioInicio, CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;
            this.cambiarColor = cambiarColor;
            cambiarColor(this);

        }

        private void FormSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show();
        }

        private void masInfo_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos(cambiarColor);

            Hide();
            DialogResult result = productos.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void rellenar_Click(object sender, EventArgs e)
        {
            FormRellenar rellenar = new FormRellenar(cambiarColor);
            Hide();
            DialogResult result = rellenar.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void productos_Click(object sender, EventArgs e)
        {
            FormCrear formCrear = new FormCrear(cambiarColor);

            Hide();
            DialogResult result = formCrear.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verMaterial_Click(object sender, EventArgs e)
        {
            Material mostrar = new Material(cambiarColor);
            mostrar.Show();
        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            FormNewOperario formNewOperario = new FormNewOperario(cambiarColor);
            formNewOperario.Show();
        }

        private void CrearSupervisor_Click(object sender, EventArgs e)
        {
            FormNewSupervisor formNewSupervisor = new FormNewSupervisor(cambiarColor);
            formNewSupervisor.Show();
        }

    }
}
