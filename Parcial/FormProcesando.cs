namespace Parcial
{
    public partial class FormProcesando : Form
    {
        

        public FormProcesando()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            // El usuario seleccionó "Sí" para aplicar barniz
            ProcesarBarniz(true);
        }

        private void negar_Click(object sender, EventArgs e)
        {
            // El usuario seleccionó "No" para no aplicar barniz
            ProcesarBarniz(false);
        }

        private void ProcesarBarniz(bool aplicarBarniz)
        {
            // Puedes pasar el estado de aplicarBarniz al siguiente formulario
            FormAprobacion formAprobacion = new FormAprobacion();

            this.Close();
            formAprobacion.Show();
        }
    }
}
