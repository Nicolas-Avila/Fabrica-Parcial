using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class MesaMadera
    {
        private string madera;
        private string plastico;

        public MesaMadera(string madera, string plastico)
        {
            this.Madera = madera;
            this.Plastico = plastico;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Plastico { get => plastico; set => plastico = value; }


        public static void CrearMesaMadera(string mesa)
        {
            if (mesa == "Mesa de madera")
            {
                if (Inventario.VerificarStock("madera", "plastico"))
                {
                    MesaMadera mesaMadera = new MesaMadera("madera", "plastico");
                    Inventario.ProductosMMadera.Add(mesaMadera);
                    Inventario.StockMateriales("madera", "plastico");
                    FormProcesando formProcesando = new FormProcesando();
                    formProcesando.Show();
                }
                else
                {
                    MessageBox.Show("Error: falta de producto");
                }
            }
        }



    }
}
