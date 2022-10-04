using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alonso_nicolas_primer_parcial_labo.Clases.enums;

namespace Clases
{
    /// <summary>
    /// Esta clase representa los datos de un alumno en una materia determinada. No confundir con la clase "materia".
    /// </summary>
    public class MateriaCursada
    {
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private int _notaFinal;
        private eRegularidad _regularidad;
        private eAsistencia _asistencia;
        private eEstadoCursada _estado;
        public MateriaCursada(string nombre, eRegularidad regularidad, eEstadoCursada estado)
        {
            _nombre = nombre;
            _regularidad = regularidad;
            _estado = estado;
            _asistencia = eAsistencia.Ausente;
        }
        public MateriaCursada(string nombre, int notaPrimerParcial, int notaSegundoParcial, eAsistencia asistencia, eRegularidad regularidad, eEstadoCursada estado) : this(nombre, regularidad, estado)
        {
            _notaPrimerParcial = notaPrimerParcial;
            _notaSegundoParcial = notaSegundoParcial;
            _asistencia = asistencia;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int NotaPrimerParcial { get => _notaPrimerParcial; set => _notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => _notaSegundoParcial; set => _notaSegundoParcial = value; }
        public int NotaFinal { get => _notaFinal; set => _notaFinal = value; }
        public eRegularidad Regularidad { get => _regularidad; set => _regularidad = value; }
        public eAsistencia Asistencia { get => _asistencia; set => _asistencia = value; }
        public eEstadoCursada Estado { get => _estado; set => _estado = value; }

        public static explicit operator string(MateriaCursada materia)
        {
            return materia.Nombre;
        }

    }
}
