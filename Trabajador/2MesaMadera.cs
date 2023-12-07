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
        private string barnis;

        public MesaDeMadera(string madera, string plastico,string barnis)
        {
            this.Madera = madera;
            this.Plastico = plastico;
            this.Barnis = barnis;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Plastico { get => plastico; set => plastico = value; }
        public string Barnis { get => barnis; set => barnis = value; }

        /// <summary>
        /// Método para crear una mesa de madera y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto,string barnis)
        {
            if (producto == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico","barnis"))
                {
                    MesaDeMadera mesaMadera = new MesaDeMadera("madera", "plastico", barnis);
                    Inventario.ProductosMMadera.Add(mesaMadera);
                    Inventario.StockMateriales("madera", "plastico", barnis);
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
