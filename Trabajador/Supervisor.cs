using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public class Supervisor : Empleado
    {
        public Supervisor(string nombre, string apellido, int id) : base(nombre, apellido, id)
        {

        }

        public static bool Inicio(string nombre, string apellido, int id)
        {

            foreach (Supervisor supervisor in Listas.IniciosSupervisor)
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
