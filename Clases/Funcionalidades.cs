using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Clase que almacena alguna que otra funcionalidad para utilizar a lo largo del programa.
    /// </summary>
    public static class Funcionalidades
    {
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
