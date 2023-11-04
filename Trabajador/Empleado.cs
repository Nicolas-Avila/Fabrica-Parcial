using System.Text;

namespace Trabajador
{
    public abstract class Empleado
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

        
       // public abstract string Info();

    }
}