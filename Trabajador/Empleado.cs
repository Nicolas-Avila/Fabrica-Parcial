using System.Text;

namespace Trabajador
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int id;

        protected Empleado(string nombre, string apellido, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(nombre);
            sb.AppendLine(apellido);
            sb.AppendLine(id.ToString());

            return sb.ToString();
        }


    }
}