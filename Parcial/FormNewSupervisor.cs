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
    public partial class FormNewSupervisor : Form
    {
        protected CambiarColor cambiarColor;
        public FormNewSupervisor(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);

        }
        private void carga()
        {
            cuadroSupervisor.DataSource = null;
            cuadroSupervisor.DataSource = CrudDAO.LeerSupervisor();
            cuadroSupervisor.Refresh();
            cuadroSupervisor.Update();
        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;

            CrudDAO.Guardar(nombre, apellido, "SUPERVISOR");
            carga();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (cuadroSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)cuadroSupervisor.CurrentRow.DataBoundItem;
                FormActualizar formActualizarOperador = new FormActualizar(supervisor.Id, "supervisor", cambiarColor);
                formActualizarOperador.ShowDialog();
                carga();
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (cuadroSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)cuadroSupervisor.CurrentRow.DataBoundItem;
                CrudDAO.Eliminar(supervisor.Id, "SUPERVISOR");
                carga();
            }
        }

        private void FormNewSupervisor_Load(object sender, EventArgs e)
        {
            carga();
        }

    }
}
