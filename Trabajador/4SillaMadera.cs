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

        public SillaMadera(string madera, string tela)
        {
            this.Madera = madera;
            this.Tela = tela;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Tela { get => tela; set => tela = value; }

        /// <summary>
        /// Método para crear una silla de madera y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto) { 

            if (producto == "Silla de madera")
            {

                if (Inventario.VerificarStock("madera", "tela"))
                {
                    SillaMadera sillaMadera = new SillaMadera("madera", "tela");
                    Inventario.ProductosSMadera.Add(sillaMadera);
                    Inventario.StockMateriales("madera", "tela");
                    return true;

                }
                return false;
            }
            return false;
            }
    }
}

