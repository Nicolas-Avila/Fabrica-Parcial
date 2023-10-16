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
    }
}

