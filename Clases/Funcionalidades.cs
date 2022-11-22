using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.VisualBasic.Logging;
using ServiceStack.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;
using XmlSerializer = System.Xml.Serialization.XmlSerializer;

namespace Clases
{
    /// <summary>
    /// Clase que almacena alguna que otra funcionalidad para utilizar a lo largo del programa.
    /// </summary>
    public static class Funcionalidades
    {
        public static bool ExportAlumnosDeMateriaJson(string nombreMateria, List<Alumno> alumnosList)
        {
            try
            {
                string nombreJson;
                string nombreCarpeta = $"Alumnos_{nombreMateria}_JSON";
                string directorioNuevo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + nombreCarpeta;
                alumnosList = SysControl.GetAlumnosMateria(nombreMateria);
                Directory.CreateDirectory(directorioNuevo);
                foreach (Alumno alumno in alumnosList)
                {
                    Alumno alum = alumno;
                    // --
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    // --
                    string jsonString = JsonSerializer.Serialize(alum, options);

                    nombreJson = "Alumno_" + $"{alumno.User}_" + $"{alumno.Nombre}_" + $"{alumno.Apellido}.json";
                    File.WriteAllText(directorioNuevo + Path.DirectorySeparatorChar + nombreJson, jsonString);
                }
                MessageBox.Show($"La carpeta contenedora se creó en la ruta: \n {directorioNuevo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, no se exportaron los datos.");
            }
            return true;
        }
        public static bool ExportAlumnosDeMateriaXml(string nombreMateria, List<Alumno> alumnosList)
        {
            try
            {
                string nombreXml;
                string nombreCarpeta = $"Alumnos_{nombreMateria}_XML";
                string directorioNuevo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + nombreCarpeta;
                alumnosList = SysControl.GetAlumnosMateria(nombreMateria);
                Directory.CreateDirectory(directorioNuevo);
                foreach (Alumno alumno in alumnosList)
                {
                    Alumno alum = alumno;
                    nombreXml = "Alumno_" + $"{alumno.User}_" + $"{alumno.Nombre}_" + $"{alumno.Apellido}.xml";
                    // Genero el objeto de configuración de la serialización.
                    using (StreamWriter streamWriter = new StreamWriter(directorioNuevo + Path.DirectorySeparatorChar + nombreXml))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));

                        xmlSerializer.Serialize(streamWriter, alumno);
                    }
                }
                MessageBox.Show($"La carpeta contenedora se creó en la ruta: \n {directorioNuevo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, no se exportaron los datos.");
            }
            return true;
        }
        public static bool ExportAlumnosDeMateriaCsv(string nombreMateria, List<Alumno> alumnosList)
        {
            try
            {
                string nombreCsv;
                string nombreCarpeta = $"Alumnos_{nombreMateria}_CSV";
                string directorioNuevo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + nombreCarpeta;
                alumnosList = SysControl.GetAlumnosMateria(nombreMateria);
                Directory.CreateDirectory(directorioNuevo);
                foreach (Alumno alumno in alumnosList)
                {
                    Alumno alum = alumno;
                    nombreCsv = "Alumno_" + $"{alumno.User}_" + $"{alumno.Nombre}_" + $"{alumno.Apellido}.csv";
                    
                    string csvString = CsvSerializer.SerializeToCsv(new[]{alumno});

                    nombreCsv = "Alumno_" + $"{alumno.User}_" + $"{alumno.Nombre}_" + $"{alumno.Apellido}.csv";
                    File.WriteAllText(directorioNuevo + Path.DirectorySeparatorChar + nombreCsv, csvString);
                }
                MessageBox.Show($"La carpeta contenedora se creó en la ruta: \n {directorioNuevo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, no se exportaron los datos.");
            }
            return true;
        }
        /// <summary>
        /// Verifica que la cadena recibida esté compuesta solo por letras del alfabeto
        /// </summary>
        /// <returns>
        /// True = Solo son letras, False = Contiene algún otro simbolo.
        /// </returns>
        public static bool IsOnlyLetters(string stringRecibido)
        {
            bool retorno = true;
            for (int i = 0; i < stringRecibido.Length; i++)
            {
                if (!Char.IsLetter(stringRecibido[i]))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Inserta el contenido de un diccionario, en otro diccionario.
        /// </summary>
        public static void AppendDict<K, V>(this Dictionary<K, V> first, Dictionary<K, V> second)
        {
            second.ToList()
                .ForEach(pair => first[pair.Key] = pair.Value);
            //second.First().Were(U => U.Key == "Labo");
        }
        /// <summary>
        /// Saca el promedio entre dos notas, devuelve el resultado.
        /// </summary>
        public static int SacarPromedio(int notaPrimero, int notaSegundo)
        {
            int promedio;
            if ((notaPrimero >= 1 && notaPrimero <= 10) && (notaSegundo >= 1 && notaSegundo <= 10))
            {
                promedio = (notaPrimero + notaSegundo) / 2;
            }
            else
            {
                throw (new Exception("Los valores ingresados deben estar entre 1 y 10"));
            }
            return promedio;
        }
    }
}
