using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class MesaMetal
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
            if (mesa == "Mesa de metal")
            {
                if (Inventario.VerificarStock("metal", "plastico"))
                {
                    MesaMetal mesaMetal = new MesaMetal("metal", "plastico");
                    Inventario.ProductosMMetal.Add(mesaMetal);
                    Inventario.StockMateriales("metal", "plastico");
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

