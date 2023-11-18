using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
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

        /// <summary>
        /// Método para crear una silla de madera y agregarla al inventario.
        /// </summary>
        public static void CrearSillaMadera(string silla) 
        {
            Inventario inventario = new Inventario();
            SillaMadera sillaMadera = new SillaMadera("madera", "tela");
            inventario.ProductosSMadera.Add(sillaMadera);
            Inventario.StockMateriales("madera", "tela");

        }
    }
}

