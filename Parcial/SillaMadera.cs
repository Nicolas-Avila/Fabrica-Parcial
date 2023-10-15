using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class SillaMadera
    {
        private string madera;
        private string tela;

        public SillaMadera(string madera, string tela)
        {
            this.madera = madera;
            this.tela = tela;
        }

        public string Material { get => madera; set => madera = value; }
        public string Tapizado { get => tela; set => tela = value; }
    }
}

