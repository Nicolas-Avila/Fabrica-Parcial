﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajador;
using static Parcial.Inicio;

namespace Parcial
{
    public partial class FormNewOperario : Form
    {

        protected CambiarColor cambiarColor;
        public FormNewOperario(CambiarColor cambiarColor)
        {
            InitializeComponent();
            this.cambiarColor = cambiarColor;
            cambiarColor(this);
        }

        private void carga()
        {
            cuadroOperario.DataSource = null;
            cuadroOperario.DataSource = CrudDAO.LeerOperarios();
            cuadroOperario.Refresh();
            cuadroOperario.Update();
        }

        private void CrearOperario_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;
            CrudDAO.Guardar(nombre, apellido, "OPERADOR");
            carga();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (cuadroOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)cuadroOperario.CurrentRow.DataBoundItem;
                FormActualizar formActualizarOperador = new FormActualizar(operario.Id, "operador", cambiarColor);
                formActualizarOperador.ShowDialog();
                carga();
            }

        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (cuadroOperario.SelectedRows.Count > 0)
            {
                Operario operario = (Operario)cuadroOperario.CurrentRow.DataBoundItem;
                CrudDAO.Eliminar(operario.Id);
                carga();
            }
        }
        private void FormNewOperario_Load(object sender, EventArgs e)
        {
            carga();
        }
    }
}
