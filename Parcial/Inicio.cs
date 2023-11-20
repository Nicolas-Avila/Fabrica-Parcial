using System.Drawing;
using System.Reflection;
using Trabajador;
using static Parcial.Config;


namespace Parcial
{
    public partial class Inicio : Form
    {
        private Color fondo;
        public delegate void CambiarColor(Form instancia);

        public Inicio(Color fondo)
        {
            InitializeComponent();
            this.fondo = fondo;
        }

        private void aceptar_Click_1(object sender, EventArgs e)
        {

            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;
            int id = (int)this.id.Value;

            if (Operario.Ingreso(nombre, apellido, id, CrudDAO.LeerOperarios()))
            {
                FormCrear formOperador = new FormCrear(cambiarColor);
                formOperador.Show();
            }
            if (Supervisor.Ingreso(nombre, apellido, id, CrudDAO.LeerSupervisor()))
            {
                FormSupervisor formSupervisor = new FormSupervisor(this, cambiarColor);
                this.Hide();
                formSupervisor.Show();
            }

        }
        private void dia_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\nicol\Desktop\Avila.Daniel.Parcial\Info\Configuracion.json";
            Config colores = new Config();
            try
            {
                if (File.Exists(path))
                {
                    Archivos<Config> colorJs = new Archivos<Config>();
                    Config coloresJson = colorJs.Leer_JSON<Config>();
                    fondo = ColorTranslator.FromHtml(coloresJson.ColorClaro);
                    cambiarColor(this);
                }
                else
                {
                    Archivos<Config> colorJs = new Archivos<Config>();
                    colorJs.EscribirJson<Config>(colores);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.error(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);

            }

        }

        private void noche_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\nicol\Desktop\Avila.Daniel.Parcial\Info\Configuracion.json";
            Config colores = new Config();
            try
            {
                if (File.Exists(path))
                {
                    Archivos<Config> colorJs = new Archivos<Config>();
                    Config coloresJson = colorJs.Leer_JSON<Config>();
                    fondo = ColorTranslator.FromHtml(coloresJson.ColorOscuro);
                    cambiarColor(this);
                }
                else
                {
                    Archivos<Config> colorJs = new Archivos<Config>();
                    colorJs.EscribirJson<Config>(colores);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.error(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);

            }
        }

        private void cambiarColor(Form instancia)
        {
            instancia.BackColor = fondo;

        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                List<Supervisor> lista = CrudDAO.LeerSupervisor();

                this.nombre.Text = lista[1].Nombre;
                this.apellido.Text = lista[1].Apellido;
                this.id.Value = lista[1].Id;

            }
            catch (Exception ex)
            {
                Archivos<string>.error(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnOperario_Click(object sender, EventArgs e)
        {
            try
            {
                List<Operario> lista = CrudDAO.LeerOperarios();

                this.nombre.Text = lista[1].Nombre;
                this.apellido.Text = lista[1].Apellido;
                this.id.Value = lista[1].Id;

            }
            catch (Exception ex)
            {
                Archivos<string>.error(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSupervisor.Click += btnSupervisor_Click;
            btnOperario.Click += btnOperario_Click;
        }
    }
}
