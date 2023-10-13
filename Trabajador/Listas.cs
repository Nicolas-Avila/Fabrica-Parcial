using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajador;
using Parcial;

namespace Parcial
{
    public static class Listas
    {
        private static List<Operario> iniciosOperario = new List<Operario>();
        private static List<Supervisor> iniciosSupervisor = new List<Supervisor>();

        public static List<Operario> IniciosOperario { get => iniciosOperario; set => iniciosOperario = value; }
        public static List<Supervisor> IniciosSupervisor { get => iniciosSupervisor; set => iniciosSupervisor = value; }
    }
}
