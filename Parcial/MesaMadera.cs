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
            this.madera = madera;
            this.plastico = plastico;
        }

        public string Material{ get => madera; set => madera = value; }
        public string Material_Extra { get => plastico; set => plastico = value; }
    }
}
