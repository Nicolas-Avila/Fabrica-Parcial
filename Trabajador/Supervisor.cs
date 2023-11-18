using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public  class Supervisor : Empleado
    {
        public Supervisor(string nombre, string apellido, int id) : base(nombre, apellido, id)
        {

        }

        /// <summary>
        /// Verifica el ingreso de un operario con nombre, apellido e ID del supervisor.
        /// </summary>
        public static bool Ingreso(string nombre, string apellido, int id,List<Supervisor>listSupervisor)
        {

            foreach (Supervisor supervisor in listSupervisor)
            {
                if (supervisor.Nombre == nombre && supervisor.Apellido == apellido && supervisor.Id == id)
                {
                    return true;

                }
                
            }
            return false;
        }

    }
}
