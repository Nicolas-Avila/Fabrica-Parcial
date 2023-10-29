﻿using System;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }

        private void CrearSillas_Click(object sender, EventArgs e)
        {
            string silla = this.sillas.Text;

            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }
            }


            SillaMadera.CrearSillaMadera(silla);
            SillaMetal.CrearSillaMetal(silla);
        }

        private void CrearMesa_Click(object sender, EventArgs e)
        {
            string mesa = this.mesas.Text;

            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }


            MesaMetal.CrearMesaMetal(mesa);
            MesaMadera.CrearMesaMadera(mesa);
        }

        private void CrearTodo_Click(object sender, EventArgs e)
        {

            string mesa = this.mesas.Text;
            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            MesaMetal.CrearMesaMetal(mesa);
            MesaMadera.CrearMesaMadera(mesa);


            string silla = this.sillas.Text;
            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }
            }
            SillaMadera.CrearSillaMadera(silla);
            SillaMetal.CrearSillaMetal(silla);
        }

        private void VerMaterial_Click(object sender, EventArgs e)
        {

            Material mostrar = new Material();
            mostrar.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

            Close();
        }


    }
}
