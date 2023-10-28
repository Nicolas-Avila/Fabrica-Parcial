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
        
        public override bool Ingreso (string nombre, string apellido, int id) {

            foreach (Operario operario in Listas.IniciosOperario)
            {

                if (operario.Nombre == nombre && operario.Apellido == apellido && operario.Id == id)
                {
                    return true;
                }
            }
                return false;
        }


        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bienvenido Operador");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Id: {Id}");
            return sb.ToString();
        }

    }
}
