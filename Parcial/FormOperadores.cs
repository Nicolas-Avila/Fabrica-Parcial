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
    public partial class FormOperadores : Form
    {



        private Inicio formularioInicio;
        public FormOperadores(Inicio formularioInicio)
        {
            InitializeComponent();
            this.formularioInicio = formularioInicio;
        }

        private void FormOperadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioInicio.Show();
        }


        private void Crear_Click(object sender, EventArgs e)
        {
            string silla = this.sillas.Text;
            string mesa = this.mesas.Text;
            FormProcesando formProcesando = new FormProcesando();

            formProcesando.Show();
            foreach (Control item in sillas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    silla = ((RadioButton)item).Text;
                }

            }
            if (silla == "Silla de madera")
            {
                SillaMadera sillaMadera = new SillaMadera("madera","tela");
                Inventario.ProductosSMadera.Add(sillaMadera);
            }
            if (silla == "Silla de metal")
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                Inventario.ProductoSMetal.Add(sillaMetal);
                
            }


            foreach (Control item in mesas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    mesa = ((RadioButton)item).Text;
                }
            }
            if (mesa == "Mesa de metal")
            {
                MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                Inventario.ProductosMMetal.Add(mesaMetal);
            }
           

            if (mesa == "Mesa de madera")
            {
                MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                Inventario.ProductosMMadera.Add(mesaMadera);
            }

        }

    }
}
