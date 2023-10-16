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
            this.Madera = madera;
            this.Tela = tela;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Tela { get => tela; set => tela = value; }
    }
}

