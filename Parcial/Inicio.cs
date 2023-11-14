using System.Reflection;
using Trabajador;
using static Parcial.Config;

namespace Parcial
{
    public partial class Inicio : Form
    {

        private Color tema;
        public Inicio()
        {
            InitializeComponent();
            this.tema = tema;
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

        private void noche_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\nicol\Desktop\Avila.Daniel.Parcial\Info\hola.json";
            Config colores = new Config();

            try
            {
                if (!(File.Exists(path)))
                {
                    Archivos<Config>.EscribirJson(colores);
                }
                else
                {
                    MessageBox.Show("awd");
                    Config coloresJson = Archivos<Config>.Leer_JSON<Config>();
                    tema = ColorTranslator.FromHtml(coloresJson.ColorClaro);
                    cambiarColor(this);
                }
            }
            catch (Exception ex)
            {
                //TextoTXT.MostrarInfoTXT(DateTime.Now, $"Error al cambiar color.",
                //MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }
        private void cambiarColor(Form instancia)
        {
            try
            {
                instancia.BackColor = tema;
            }
            catch (Exception ex)
            {
                //TextoTXT.MostrarInfoTXT(DateTime.Now, $"Error al cambiar color: {ex.Message}.",
                //MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}