using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class SillaMetal
    {
        private string metal;
        private string tela;

        public SillaMetal(string metal, string tela)
        {
            this.metal = metal;
            this.tela = tela;
        }

        public string Material { get => metal; set => metal = value; }
        public string Tapizado { get => tela; set => tela = value; }
   

    }

}

