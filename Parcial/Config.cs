
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Config
    {
            private string colorOscuro;
            private string colorClaro;

            public Config()
            {
                ColorOscuro = "#656869";
                ColorClaro = "#58D8EC";
            }

            public string ColorOscuro { get => colorOscuro; set => colorOscuro = value; }
            public string ColorClaro { get => colorClaro; set => colorClaro = value; }
        
    }




}
