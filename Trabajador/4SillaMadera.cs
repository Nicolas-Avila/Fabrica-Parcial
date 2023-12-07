using Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class SillaMadera : ICreacion
    {
        private string madera;
        private string tela;
        private string barnis;
        public SillaMadera(string madera, string tela, string barnis)
        {
            this.Madera = madera;
            this.Tela = tela;
            this.Barnis = barnis;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Tela { get => tela; set => tela = value; }
        public string Barnis { get => barnis; set => barnis = value; }

        /// <summary>
        /// Método para crear una silla de madera y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto, string barnis) { 

            if (producto == "Silla de madera")
            {

                if (Inventario.VerificarStock("madera", "tela", "barnis"))
                {
                    SillaMadera sillaMadera = new SillaMadera("madera", "tela", barnis);
                    Inventario.ProductosSMadera.Add(sillaMadera);
                    Inventario.StockMateriales("madera", "tela", barnis);
                    return true;

                }
                return false;
            }
            return false;
            }
    }
}

