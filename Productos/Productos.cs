using System.Reflection.Metadata;

namespace Productos
{
    public class Productos
    {
        private int madera;
        private int metal;
        private int tela;
        private int plastico;

        public Productos(int madera, int metal, int tela, int plastico)
        {
            this.madera = madera;
            this.metal = metal;
            this.tela = tela;
            this.plastico = plastico;
        }

        public int Madera { get => madera; set => madera = value; }
        public int Metal { get => metal; set => metal = value; }
        public int Tela { get => tela; set => tela = value; }
        public int Plastico { get => plastico; set => plastico = value; }
    }
}