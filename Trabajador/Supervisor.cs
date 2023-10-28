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

        public override bool Ingreso(string nombre, string apellido, int id)
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

        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bienvenido Supervisor");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"ID: {Id}");
            return sb.ToString();
        }


    }
}
