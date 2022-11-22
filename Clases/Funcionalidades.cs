using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.VisualBasic.Logging;
using ServiceStack.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;
using XmlSerializer = System.Xml.Serialization.XmlSerializer;
using alonso_nicolas_primer_parcial_labo.Clases;

namespace Clases
{
    /// <summary>
    /// Clase que almacena alguna que otra funcionalidad para utilizar a lo largo del programa.
    /// </summary>
    public static class Funcionalidades
    {
        public static bool ExportAlumnosDeMateriaXml(string nombreMateria, List<Alumno> alumnosList)
        {
            var serializador = new SerializacionXml<Alumno>();
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
                    string lastPath = directorioNuevo + Path.DirectorySeparatorChar + nombreXml;
                    serializador.Serialize(alumno, lastPath);
                }
                MessageBox.Show($"La carpeta contenedora se creó en la ruta: \n {directorioNuevo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, no se exportaron los datos.");
            }
            return true;
        }
        public static bool ExportAlumnosDeMateriaJson(string nombreMateria, List<Alumno> alumnosList)
        {
            var serializador = new SerializacionXml<Alumno>();
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
                    nombreJson = "Alumno_" + $"{alumno.User}_" + $"{alumno.Nombre}_" + $"{alumno.Apellido}.json";
                    string pathFinal = directorioNuevo + Path.DirectorySeparatorChar + nombreJson;
                    serializador.Serialize(alum, pathFinal);
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
            var serializador = new SerializacionXml<Alumno>();
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
                    string pathFinal = directorioNuevo + Path.DirectorySeparatorChar + nombreCsv;
                    serializador.Serialize(alumno, pathFinal);
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
