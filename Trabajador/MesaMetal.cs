using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public class MesaMetal
    {
        private string metal;
        private string plastico;

        public MesaMetal(string metal, string plastico)
        {
            this.Metal = metal;
            this.Plastico = plastico;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Plastico { get => plastico; set => plastico = value; }

        /// <summary>
        /// Método para crear una mesa de metal y agregarla al inventario.
        /// </summary>
        public static void CrearMesaMetal(string mesa)
        {
            Inventario inventario = new Inventario();
            //MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
            inventario.productosMMetal.Add(mesaMetal);
            
            Inventario.StockMateriales("metal", "plastico");
        }


    }
}

