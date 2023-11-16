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
    public partial class FormActualizar : Form
    {
        private int id;
        private string trabajador;
        protected CambiarColor cambiarColor;
        public FormActualizar(int id, string trabajador, CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.id = id;
            this.trabajador = trabajador;
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;
            if (trabajador == "operador")
            {
                CrudDAO.Actualizar(nombre, apellido, id, "OPERADOR");
            }
            else
            {
                CrudDAO.Actualizar(nombre, apellido, id, "SUPERVISOR");
            }

        }
    }
}
