using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace alonso_nicolas_primer_parcial_labo.Clases
{
    public class SerializacionJson<T> : ISerializador<T>
        where T : class, new ()
    {
        public void Serialize(T serializedObj, string path)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                // --
                string jsonString = JsonSerializer.Serialize(serializedObj, options);
                File.WriteAllText(path, jsonString);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
