using Clases.enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Esta clase representa un examen academico. Almacena los datos correspondientes a un examen
    /// </summary>
    public class Examen
    {
        private string _nombre;
        private string _materia;
        private DateTime _fecha;
        public Examen(string nombre, string materia, DateTime fecha)
        {
            _nombre = nombre;
            _materia = materia;
            _fecha = fecha;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public static explicit operator Examen(SqlDataReader v)
        {
            Examen p = new Examen
                (
                v["nombre"].ToString() ?? "", v["nombreMateria"].ToString() ?? "",
                (DateTime)v["fecha"]
                );

            return p;
        }
    }
}
