using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class SillaMadera
    {
        private string madera;
        private string tela;

        public SillaMadera(string madera, string tela)
        {
            this.Madera = madera;
            this.Tela = tela;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Tela { get => tela; set => tela = value; }

        public static void CrearSillaMadera(string silla) { 

            if (silla == "Silla de madera")
            {

                if (Inventario.VerificarStock("madera", "tela"))
                {
                    SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                    Inventario.ProductosSMadera.Add(sillaMadera);
                    Inventario.StockMateriales("madera", "tela");
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

