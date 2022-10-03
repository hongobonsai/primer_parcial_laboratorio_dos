using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Clases.enums;

namespace Clases
{
    public class Materia
    {
        private string? _nombre;
        private string? _correlativa;
        private eCuatrimestre _cuatrimestre;
        private List<Profesor>? _profesores;
        private List<Alumno>? _alumnos;

        public Materia(string? nombre, eCuatrimestre cuatrimestre)
        {
            _nombre = nombre;
            _cuatrimestre = cuatrimestre;
            _correlativa = "Ninguna";
            _profesores = new List<Profesor>();
            _alumnos = new List<Alumno>();
        }
        public Materia(string? nombre, eCuatrimestre cuatrimestre, string? correlativa) : this (nombre, cuatrimestre)
        {
            _correlativa = correlativa;
        }

        public string? Nombre { get => _nombre; set => _nombre = value; }
        public eCuatrimestre Cuatrimestre { get => _cuatrimestre; set => _cuatrimestre = value; }
        public List<Profesor>? Profesores { get => _profesores; set => _profesores = value; }
        public List<Alumno>? Alumnos { get => _alumnos; set => _alumnos = value; }
        public Profesor Profesor
        {
            set
            {
                if (value is null)
                {
                    throw new Exception("Verifique el campo profesor");
                }
                _profesores.Add(value);
            }
        }
        public string? Correlativa { get => _correlativa; set => _correlativa = value; }
    }
}
