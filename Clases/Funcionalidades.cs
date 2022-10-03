using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Funcionalidades
    {
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
        public static void AppendDict<K, V>(this Dictionary<K, V> first, Dictionary<K, V> second)
        {
            second.ToList()
                .ForEach(pair => first[pair.Key] = pair.Value);
        }
    }
}
