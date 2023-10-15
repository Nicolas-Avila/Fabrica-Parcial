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

                   
           if( Operario.Ingreso(nombre, apellido, id))
            {
                FormOperadores formOperador = new FormOperadores(this);
                this.Hide();
                formOperador.Show();
                
            }
           
           if(Supervisor.Inicio(nombre, apellido, id))
            {
                FormSupervisor formSupervisor = new FormSupervisor(this);
                this.Hide();
                formSupervisor.Show();                
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Operario operario1 = new Operario("nico", "avila", 1);
            Operario operario2 = new Operario("santiago", "varista", 2);

            Supervisor supervisor1 = new Supervisor("martin", "alcaraz", 5);
            Supervisor supervisor2 = new Supervisor("luciano", "somas", 7);

            Listas.IniciosOperario.Add(operario1);
            Listas.IniciosOperario.Add(operario2);

            Listas.IniciosSupervisor.Add(supervisor1);
            Listas.IniciosSupervisor.Add(supervisor2);
        }

        private void btnOperario_Click(object sender, EventArgs e)
        {
            this.nombre.Text = "nico";
            this.apellido.Text = "avila";
            this.id.Value = 1;
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            this.nombre.Text = "martin";
            this.apellido.Text = "alcaraz";
            this.id.Value = 5;

        }
    }
}