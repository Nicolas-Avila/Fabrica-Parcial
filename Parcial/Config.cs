
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
                ColorOscuro = "#A5A3A2";
                ColorClaro = "#0FB0CA";
            }

            public string ColorOscuro { get => colorOscuro; set => colorOscuro = value; }
            public string ColorClaro { get => colorClaro; set => colorClaro = value; }
        
    }




}
