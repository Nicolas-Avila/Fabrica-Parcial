using Fabrica;
using System;


namespace Parcial
{
    public class SillaMetal : ICreacion
    {
        private string metal;
        private string tela;

        public SillaMetal(string metal, string tela)
        {
            this.Metal = metal;
            this.Tela = tela;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Tela { get => tela; set => tela = value; }

        /// <summary>
        /// Método para crear una silla de matal y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto)
    {
        if (producto == "Silla de metal")
        {
            if (Inventario.VerificarStock("metal", "tela"))
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela");
                Inventario.ProductoSMetal.Add(sillaMetal);
                Inventario.StockMateriales("metal", "tela");
                    return true;
            }
            return false;
        }
            return false;
    }

    }
}
