using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Archivos
    {
        public static void crearArchivo(string nombreArchvio,string extension,string datos)
        {
            string path = @"C:\Users\nicol\Desktop\Avila.Daniel.Parcial\Info";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                                
            }

            if (Directory.Exists(path))
            {

                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string archivo = $"{path}/{nombreArchvio}.{extension}";
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(fechaHora);
                    sw.WriteLine(datos);
                }
            }


        }
    }
}

