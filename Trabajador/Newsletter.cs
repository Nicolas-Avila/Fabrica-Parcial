// Clase Newsletter
using System;

namespace Fabrica
{
    public class Newsletter
    {
        public delegate void NovedadHandler(Newsletter sender, string mensaje);
        public event NovedadHandler NovedadEnviada;
        private string tema;

        public Newsletter(string tema)
        {
            this.tema = tema;
        }

        public string Tema => tema;

        public void EnviarNovedades()
        {
            if (NovedadEnviada is not null)
            {
                NovedadEnviada.Invoke(this, "Stock " + tema);
            }
        }
    }
}
