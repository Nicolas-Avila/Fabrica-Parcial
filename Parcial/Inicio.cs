using Fabrica;
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
            Operario operario = new Operario(nombre, apellido, id);
            Supervisor supervisor = new Supervisor(nombre, apellido, id);
            if (operario.ingreso(nombre, apellido, id, CrudDAO.LeerOperarios()))
            {
                FormCrear formOperador = new FormCrear(cambiarColor);
                formOperador.Show();
            }
            else if (supervisor.ingreso(nombre, apellido, id, CrudDAO.LeerSupervisor()))
            {
                FormSupervisor formSupervisor = new FormSupervisor(this, cambiarColor);
                this.Hide();
                formSupervisor.Show();
            }
            else
            {
                MessageBox.Show("Ese trabajador no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void dia_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                string path = Path.Combine(@"C:\Users\nicol\Desktop\a", @"laboratorio_2_Parcial\Info\Configuracion.json");
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
                    string mensajeExcepcion = "Ese color no existe";
                    Archivos<string>.error(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, mensajeExcepcion);
                    //throw new Exception(mensajeExcepcion);
                }
            });
        }

        private async void noche_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                string path = Path.Combine(@"C:\Users\nicol\Desktop\a", @"laboratorio_2_Parcial\Info\Configuracion.json");
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
            });
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
                throw new MiExcepcion($"Ocurrio un error con el supervisor: {ex.Message}", ex);
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
