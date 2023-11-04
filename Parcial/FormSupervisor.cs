﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajador;

namespace Parcial
{
    public partial class FormSupervisor : Form
    {

        private Inicio formularioInicio;

        public FormSupervisor(Inicio formularioInicio)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;

        }

        private void FormSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show();
        }

        private void masInfo_Click(object sender, EventArgs e)
        {
            Informacion mostrarOperario = new Informacion();

            Hide();
            DialogResult result = mostrarOperario.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void rellenar_Click(object sender, EventArgs e)
        {
            FormRellenar rellenar = new FormRellenar();
            Hide();
            DialogResult result = rellenar.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }

        }

        private void productos_Click(object sender, EventArgs e)
        {
            FormCrear formOperador = new FormCrear();

            Hide();
            DialogResult result = formOperador.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verMaterial_Click(object sender, EventArgs e)
        {
            Material mostrar = new Material();
            mostrar.Show();
        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;

            CrudDAO.GuardarOperario(nombre, apellido);
        }

        private void CrearSupervisor_Click_1(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;

            CrudDAO.GuardarSupervisor(nombre, apellido);
        }
    }
}
