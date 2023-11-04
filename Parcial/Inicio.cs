using Trabajador;

namespace Parcial
{
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
        }


        private void aceptar_Click_1(object sender, EventArgs e)
        {

            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;
            int id = (int)this.id.Value;



            if (Operario.Ingreso(nombre, apellido, id, CrudDAO.LeerOperarios()))
            {
                FormCrear formOperador = new FormCrear();
                //MessageBox.Show(ingresanteOp.Info());
                formOperador.Show();

            }


            if (Supervisor.Ingreso(nombre, apellido, id, CrudDAO.LeerSupervisor()))
            {
                FormSupervisor formSupervisor = new FormSupervisor(this);
                //MessageBox.Show(Supervisor.Info());
                this.Hide();
                formSupervisor.Show();
            }

        }



    }
}