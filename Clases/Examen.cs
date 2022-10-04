using System;
using System.Collections.Generic;
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
    }
}
