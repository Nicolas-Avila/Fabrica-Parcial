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
        public  bool CrearProducto(string producto)
        {
            if (producto == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico"))
                {
                    MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                    Inventario.ProductosMMetal.Add(mesaMetal);
                    Inventario.StockMateriales("metal", "plastico");
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

