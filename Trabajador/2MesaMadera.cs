using Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Parcial
{
    public class MesaDeMadera : ICreacion
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
        public  bool CrearProducto(string producto)
        {
            if (producto == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico"))
                {
                    MesaDeMadera mesaMadera = new MesaDeMadera("madera", "plastico");
                    Inventario.ProductosMMadera.Add(mesaMadera);
                    Inventario.StockMateriales("madera", "plastico");
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
