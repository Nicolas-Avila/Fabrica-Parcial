using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial;


namespace Trabajador
{
    public class MesaDeMadera
    {
        private string madera;
        private string plastico;

        public MesaDeMadera(string madera, string plastico)
        {
            this.Madera = madera;
            this.Plastico = plastico;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Plastico { get => plastico; set => plastico = value; }

        /// <summary>
        /// Método para crear una mesa de madera y agregarla al inventario.
        /// </summary>
        public static void CrearMesaMadera(string mesa)
        {
            Inventario inventario = new Inventario();
            MesaDeMadera mesaMadera = new MesaDeMadera("madera", "plastico");
            
            Inventario.StockMateriales("madera", "plastico");        
                        
        }

    }
}
