using System;
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
        {"madera",10 },
        {"metal",10 },
        {"plastico",10 },
        {"tela",10 }
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



        public static bool verificarStock(string mesa, string silla)
    {
        var cont = 0;
        foreach (var item in Stock)
        {



            
        }
            return false;
    }

       


    }
}



