using Fabrica;
using System;


namespace Parcial
{
    public class SillaMetal : ICreacion
    {
        private string metal;
        private string tela;
        private string barnis;
        public SillaMetal(string metal, string tela,string barnis)
        {
            this.Metal = metal;
            this.Tela = tela;
            this.Barnis = barnis;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Tela { get => tela; set => tela = value; }
        public string Barnis { get => barnis; set => barnis = value; }
        /// <summary>
        /// Método para crear una silla de matal y agregarla al inventario.
        /// </summary>
        public  bool CrearProducto(string producto, string barnis)
    {
        if (producto == "Silla de metal")
        {
            if (Inventario.VerificarStock("metal", "tela", "barnis"))
            {
                SillaMetal sillaMetal = new SillaMetal("metal", "tela", barnis);
                Inventario.ProductoSMetal.Add(sillaMetal);
                Inventario.StockMateriales("metal", "tela", barnis);
                    return true;
            }
            return false;
        }
            return false;
    }

    }
}
