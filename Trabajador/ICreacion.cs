using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal interface ICreacion
    {
        bool CrearProducto(string producto, string barnis);
    }
}
