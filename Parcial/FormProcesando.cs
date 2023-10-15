using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormProcesando : Form
    {
        private System.Windows.Forms.Timer timer;

        public FormProcesando()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += timer1_Tick;
            timer.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            FormAprobacion formAprobacion = new FormAprobacion();


            this.Close();
            formAprobacion.Show();

        }

    }

}
