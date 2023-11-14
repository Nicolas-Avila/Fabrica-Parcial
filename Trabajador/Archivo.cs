using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
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

        public static void EscribirJson<T>(T objeto)
        {
            string archivo = $"{path}/hola.json";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(objeto, options);

            File.WriteAllText(archivo, jsonString);
        }

        public static T Leer_JSON<T>()
        {
            string archivo = $"{path}/hola.json";
            string jsonString = File.ReadAllText(archivo);
            T objeto = JsonSerializer.Deserialize<T>(jsonString);

            return objeto;
        }

    }
}
