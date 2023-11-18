//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public  class Inventario
    {
        public static  Dictionary<string, int> stock = new Dictionary<string, int>()
        {
            {"madera", 10 },
            {"metal", 10 },
            {"plastico", 10 },
            {"tela", 10 }

        };


        public  Dictionary<string, int> Stock { get => stock; set => stock = value; }
        public  List<SillaMadera> ProductosSMadera { get => productosSMadera; set => productosSMadera = value; }
        public  List<SillaMetal> ProductoSMetal { get => productosSMetal; set => productosSMetal = value; }
        public  List<MesaDeMadera> ProductosMMadera { get => productosMMadera; set => productosMMadera = value; }
        public  List<MesaMetal> ProductosMMetal { get => productosMMetal; set => productosMMetal = value; }

        public List<SillaMadera> productosSMadera = new List<SillaMadera>();
        public List<SillaMetal> productosSMetal = new List<SillaMetal>();
        public List<MesaDeMadera> productosMMadera = new List<MesaDeMadera>();
        public List<MesaMetal> productosMMetal = new List<MesaMetal>();

        /// <summary>
        ///  Descuenta el material del inventario.
        /// </summary>
        /// 

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
