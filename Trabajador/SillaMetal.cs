using System;


namespace Trabajador
{
    public class SillaMetal
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
        public static void CrearSillaMetal(string silla)
    {
            Inventario inventario = new Inventario();
            SillaMetal sillaMetal = new SillaMetal("metal", "tela");
            inventario.ProductoSMetal.Add(sillaMetal);
            Inventario.StockMateriales("metal", "tela");        
    }

    }
}
