using Parcial;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje) { }
        public MiExcepcion(string mensaje, Exception inner) : base(mensaje, inner) { }
        
    }
}

