using Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class MesaMetal : ICreacion
    {
        private string metal;
        private string plastico;
        private string barnis;

        public MesaMetal(string metal, string plastico,string barnis)
        {
            this.Metal = metal;
            this.Plastico = plastico;
            this.Barnis = barnis;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Plastico { get => plastico; set => plastico = value; }
        public string Barnis { get => barnis; set => barnis = value; }

        /// <summary>
        /// Método para crear una mesa de metal y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto, string barnis)
        {
            if (producto == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico", "barnis"))
                {
                    MesaMetal mesaMetal = new MesaMetal("metal", "plastico", barnis);
                    Inventario.ProductosMMetal.Add(mesaMetal);
                    Inventario.StockMateriales("metal", "plastico", barnis);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }


    }
}

