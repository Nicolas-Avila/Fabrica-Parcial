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
    public partial class FormNewOperario : Form
    {

        
        public FormNewOperario()
        {
            InitializeComponent();
            cuadroOperario.DataSource = CrudDAO.LeerOperarios();
            
        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;

            CrudDAO.Guardar(nombre, apellido, "OPERADOR");
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (cuadroOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)cuadroOperario.CurrentRow.DataBoundItem;
                FormActualizar formActualizarOperador = new FormActualizar(operario.Id, "operador");
                formActualizarOperador.Show();
            }

        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (cuadroOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)cuadroOperario.CurrentRow.DataBoundItem;
                CrudDAO.Eliminar(operario.Id,"OPERADOR");
            }
        }
    }
}
