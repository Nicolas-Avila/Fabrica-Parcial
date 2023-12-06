using Fabrica;
using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador
{
    public  class Supervisor : Empleado, Iingreso
    {
        public Supervisor(string nombre, string apellido, int id) : base(nombre, apellido, id)
        {

        }

        /// <summary>
        /// Verifica el ingreso de un operario con nombre, apellido e ID del supervisor.
        /// </summary>
        public bool ingreso<T>(string nombre, string apellido, int id, List<T>lista)
        {

            if (typeof(T) == typeof(Supervisor))
            {
                // Convierte la lista a List<Operario> si el tipo genérico es Operario
                List<Supervisor> listOperarios = lista as List<Supervisor>;

                foreach (Supervisor operario in listOperarios)
                {
                    if (operario.Nombre == nombre && operario.Apellido == apellido && operario.Id == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
