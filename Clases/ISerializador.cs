using Clases;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;
using XmlSerializer = System.Xml.Serialization.XmlSerializer;

namespace alonso_nicolas_primer_parcial_labo.Clases
{
    public interface ISerializador<T> where T : class
    {
        void Serialize(T obj, string path);
    }
}
