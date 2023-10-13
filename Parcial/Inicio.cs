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
            

            foreach (Operario operario in Listas.IniciosOperario)
            {
               
                if (operario.Nombre == nombre && operario.Apellido == apellido && operario.Id == id)
                {
                    FormOperador formOperador = new FormOperador(this);
                    this.Hide();
                    formOperador.Show();
                    break;
                }
            }

            foreach (Supervisor supervisor in Listas.IniciosSupervisor)
            {
                if (supervisor.Nombre == nombre && supervisor.Apellido == apellido && supervisor.Id == id)
                {
                    FormSupervisor formSupervisor = new FormSupervisor();
                    this.Hide();
                    formSupervisor.Show();
                    break;
                }
            }


        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            Operario operario1 = new Operario("nico","avila",1);
            Operario operario2 = new Operario("nico2", "avila2", 2);

            Supervisor supervisor1 = new Supervisor("Thiago", "tamos",1);
            Supervisor supervisor2 = new Supervisor("Thiago2", "tamos2", 2);

            Listas.IniciosOperario.Add(operario1);
            Listas.IniciosOperario.Add(operario2);
            
            Listas.IniciosSupervisor.Add(supervisor1);
            Listas.IniciosSupervisor.Add(supervisor2);
        }

      
    }
}