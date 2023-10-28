using System;
using System.Windows.Forms;

namespace Parcial
{
    public class SillaMetal
    {
        private string metal;
        private string tela;

        public SillaMetal(string metal, string tela)
        {
            this.Metal = metal;
            this.Tela = tela;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Tela { get => tela; set => tela = value; }
    

    public static void CrearSillaMetal(string silla)
    {
        if (silla == "Silla de metal")
        {
            if (Inventario.VerificarStock("metal", "tela"))
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                Inventario.ProductoSMetal.Add(sillaMetal);
                Inventario.StockMateriales("metal", "tela");
                FormProcesando formProcesando = new FormProcesando();
                formProcesando.Show();
            }
            else
            {
                MessageBox.Show("Error: falta de producto");
            }
        }
    }

    }
}
