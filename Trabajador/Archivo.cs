using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Parcial
{
    public class Archivos<T>
    {
        static string path = @"C:\Users\nicol\Desktop\Avila.Daniel.Parcial\Info";

        public static void crearArchivo(string nombreArchivo, string extension, string datos)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (Directory.Exists(path))
            {
                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string archivo = $"{path}/{nombreArchivo}.{extension}";
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(fechaHora);
                    sw.WriteLine(datos);
                }
            }
        }

        public static void crearXml(T objeto)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (Directory.Exists(path))
            {                
                string archivo = $"{path}/Stock.xml";
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, objeto);
                }
            }
        }
    
        
    
    }
}
