using Fabrica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Parcial
{
    public class Archivos<T>:Iarchios<T>
    {

        string path = Path.Combine(@"C:\Users\nicol\Desktop\a", @"laboratorio_2_Parcial\Info");

        public bool CrearTxt(string dato)
        {
            string archivo = $"{path}/Errores.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))
                {
                    sw.WriteLine(dato);
                }
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }
              
        public static void error(DateTime fechaHora,string clase, string metodo, string mensaje)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(fechaHora.ToString());
            sb.AppendLine($"Clase:{clase}");
            sb.AppendLine($"Metodo:{metodo}");
            sb.AppendLine($"Error:{mensaje}");

            Archivos<string> crearTxt = new Archivos<string>();
            crearTxt.CrearTxt(sb.ToString());
            
        }

        public void crearXml(T objeto)
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

        public void EscribirJson<T>(T objeto)
        {
            string archivo = $"{path}/Configuracion.json";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(objeto, options);

            File.WriteAllText(archivo, jsonString);
        }

        public  T Leer_JSON<T>()
        {
            string archivo = $"{path}/Configuracion.json";
            string jsonString = File.ReadAllText(archivo);
            T objeto = JsonSerializer.Deserialize<T>(jsonString);

            return objeto;
        }

    }
}
