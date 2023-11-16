using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal interface Iarchios<T>
    {
        bool CrearTxt(string dato);
        void crearXml(T objeto);
        void EscribirJson<T>(T objeto);
        T Leer_JSON<T>();

    }
}
