using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class MesaMadera
    {
        private string madera;
        private string plastico;

        public MesaMadera(string madera, string plastico)
        {
            this.Madera = madera;
            this.Plastico = plastico;
        }

        public string Madera { get => madera; set => madera = value; }
        public string Plastico { get => plastico; set => plastico = value; }
    }
}
