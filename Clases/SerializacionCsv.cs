using Clases;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace alonso_nicolas_primer_parcial_labo.Clases
{
    internal class SerializacionCsv<T> : ISerializador<T>
        where T : class, new()
    {
        public void Serialize(T serializedObj, string path)
        {
            try
            {
                string csvString = CsvSerializer.SerializeToCsv(new[] { serializedObj });
                File.WriteAllText(path, csvString);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
