using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Newsletter
    {
        public delegate void NovedadHandler(Newsletter sender, string mensaje);
        public event NovedadHandler Novedad;
        private string tema;

        public Newsletter(string tema) {
            this.tema = tema;        
        }

        public string Tema => tema;

        public void EnviarNovedad()
        {
            if (Novedad is not null)
            {
                Novedad.Invoke(this, "TEST");
            }
        }

    }
}
