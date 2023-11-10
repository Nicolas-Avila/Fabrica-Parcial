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

namespace Parcial
{
    public partial class FormNewSupervisor : Form
    {
        public FormNewSupervisor()
        {
            InitializeComponent();
            cuadroSupervisor.DataSource = CrudDAO.LeerSupervisor();

        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;

            CrudDAO.Guardar(nombre, apellido, "SUPERVISOR");
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (cuadroSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)cuadroSupervisor.CurrentRow.DataBoundItem;
                FormActualizar formActualizarOperador = new FormActualizar(supervisor.Id, "supervisor");
                formActualizarOperador.Show();
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (cuadroSupervisor.SelectedRows.Count > 0)
            {
                Supervisor supervisor = (Supervisor)cuadroSupervisor.CurrentRow.DataBoundItem;
                CrudDAO.Eliminar(supervisor.Id, "SUPERVISOR");
            }
        }
    }
}
