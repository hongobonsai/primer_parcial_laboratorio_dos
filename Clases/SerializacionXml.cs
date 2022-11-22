using Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace alonso_nicolas_primer_parcial_labo.Clases
{
    public class SerializacionXml<T> : ISerializador<T>
        where T : class, new()
    {
        public void Serialize(T serializedObj, string path)
        {
            try
            {
                // Genero el objeto de configuración de la serialización.
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(streamWriter, serializedObj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
