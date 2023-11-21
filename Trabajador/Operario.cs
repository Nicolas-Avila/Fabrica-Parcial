using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Trabajador
{
    public class Operario : Empleado
    {
       public Operario(string nombre, string apellido, int id) : base(nombre,apellido,id)
        {
                        
        }
        /// <summary>
        /// Verifica el ingreso de un operario con nombre, apellido e ID del operario.
        /// </summary>
        public override bool Ingreso<T>(string nombre, string apellido, int id, List<T> lista)
        {

            if (typeof(T) == typeof(Operario))
            {
                // Convierte la lista a List<Operario> si el tipo genérico es Operario
                List<Operario> listOperarios = lista as List<Operario>;

                foreach (Operario operario in listOperarios)
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
