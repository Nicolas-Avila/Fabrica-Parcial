//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    static class Inventario
    {
        private static Dictionary<string, int> stock = new Dictionary<string, int>()
        {
            {"madera", 10 },
            {"metal", 10 },
            {"plastico", 10 },
            {"tela", 10 }
        };

        public static Dictionary<string, int> Stock { get => stock; set => stock = value; }
        public static List<SillaMadera> ProductosSMadera { get => productosSMadera; set => productosSMadera = value; }
        public static List<SillaMetal> ProductoSMetal { get => productosSMetal; set => productosSMetal = value; }
        public static List<MesaMadera> ProductosMMadera { get => productosMMadera; set => productosMMadera = value; }
        public static List<MesaMetal> ProductosMMetal { get => productosMMetal; set => productosMMetal = value; }

        private static List<SillaMadera> productosSMadera = new List<SillaMadera>();
        private static List<SillaMetal> productosSMetal = new List<SillaMetal>();
        private static List<MesaMadera> productosMMadera = new List<MesaMadera>();
        private static List<MesaMetal> productosMMetal = new List<MesaMetal>();




        /// <summary>
        ///  Descuenta el material del inventario.
        /// </summary>
        public static void StockMateriales(string material1, string material2)
        {
            foreach (var componente in stock)
            {
                if (componente.Key == material1 && componente.Value > 0)
                {
                    stock[componente.Key] -= 1;
                }
                else if (componente.Key == material2 && componente.Value > 0)
                {
                    stock[componente.Key] -= 1;
                }
            }
        }


        public static bool VerificarStock(string material1, string material2)
        {
            var cont = 0;

            foreach (var componente in stock)
            {
                if (componente.Key == material1 && componente.Value > 0)
                {
                    cont += 1;
                }
                else if (componente.Key == material2 && componente.Value > 0)
                {
                    cont += 1;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            return false;
        }





    }
}
