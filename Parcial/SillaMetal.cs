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
            this.Metal = metal;
            this.Tela = tela;
        }

        public string Metal { get => metal; set => metal = value; }
        public string Tela { get => tela; set => tela = value; }
    }

}

