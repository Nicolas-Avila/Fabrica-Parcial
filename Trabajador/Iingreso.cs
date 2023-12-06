using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal interface Iingreso
    {
        bool ingreso<T>(string nombre, string apellido, int id, List<T> lista);
    }
}
