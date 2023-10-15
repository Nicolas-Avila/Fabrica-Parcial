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
            this.metal = metal;
            this.plastico = plastico;
        }

        public string Material { get => metal; set => metal = value; }
        public string Material_Extra { get => plastico; set => plastico = value; }
    }
}

