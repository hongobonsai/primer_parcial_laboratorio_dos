using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alonso_nicolas_primer_parcial_labo.Clases.enums;
using Clases.enums;

namespace Clases
{
    /// <summary>
    /// Esta clase representa a un alumno. Almacena los datos correspondientes al alumno.
    /// Hereda de Academico
    /// </summary>
    public sealed class Alumno : Academico
    {
        private List<MateriaCursada>? _materiasCursadas;

        public Alumno(string? user, string? pass, eType type, string? nombre, string? apellido, int dni,
            DateTime nacimiento, eGenero genero) : base(user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            _materiasCursadas = new();
        }
        public List<MateriaCursada>? MateriasCursadas
        {
            get { return _materiasCursadas; }
            set { _materiasCursadas = value; }
        }
        /// <summary>
        /// Inscribe a un alumno en la materia obtenida a partir del nombre recibido por parametro.
        /// Busca la materia correspondiente en la lista de materias, y en caso que el alumno cumpla las condiciones (tenga aprobada la correlativa y no la este cursando/ya la haya aprobado), lo agrega a la lista.
        /// </summary>
        public static MateriaCursada? InscribirseMateria(string? nombreMateria, Alumno alumno)
        {
            MateriaCursada retorno = null;
            Materia? materiaBuff;
            MateriaCursada materiaInscribirse;
            bool cursoCorrelativa = false;
            if (nombreMateria != "")
            {
                try
                {
                    materiaBuff = SysControl.GetMateria(nombreMateria);
                    foreach (Alumno alum in materiaBuff.Alumnos)
                    {
                        if (alum.User == alumno.User)
                        {
                            throw new Exception("El alumno ya está inscripto a la materia.");
                        }
                    }
                    foreach (MateriaCursada materia in alumno._materiasCursadas)
                    {
                        if (materia.Estado == eEstadoCursada.Aprobada && materia.Nombre == nombreMateria)
                        {
                            throw new Exception("El alumno ya aprobó esta materia.");
                        }
                        if (materiaBuff.Correlativa != "Ninguna")
                        {
                            if ((string)materia == materiaBuff.Correlativa)
                            {
                                cursoCorrelativa = true;
                                if (materia.Estado != eEstadoCursada.Aprobada)
                                {
                                    throw new Exception("El alumno no aprobó la correlativa correspondiente.");
                                }
                            }
                        }
                    }
                    if (materiaBuff.Correlativa != "Ninguna" && cursoCorrelativa == false)
                    {
                        throw new Exception("El alumno no cursó la correlativa correspondiente.");
                    }
                    alumno.PuedeInscribirse();
                    materiaBuff.Alumnos.Add(alumno);
                    materiaInscribirse = new(nombreMateria, eRegularidad.Regular, eEstadoCursada.Cursando);
                    alumno.MateriasCursadas.Add(materiaInscribirse);
                    retorno = materiaInscribirse;
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }

            }
            else
            {
                throw new Exception("Verificar el campo materia.");
            }
            return retorno;
        }
        /// <summary>
        /// Carga la asistencia recibida por parametro en el atributo _asistencia de la Materia Cursada del alumno.
        /// </summary>
        public bool PresentarAsistencia(string? nombreMateria, eAsistencia asistencia)
        {
            MateriaCursada? materiaBuff;
            materiaBuff = GetMateriaEnCurso(nombreMateria);
            materiaBuff.Asistencia = asistencia;

            return true;
        }
        /// <summary>
        /// Obtiene la materia EN CURSO a partir del nombre recibido por parametro. Si la materia no está en curso, lanza una excepcion.
        /// </summary>
        public MateriaCursada? GetMateriaEnCurso(string? nombreMateria)
        {
            MateriaCursada? materiaCursada = null;
            foreach (MateriaCursada? materia in _materiasCursadas)
            {
                if (materia.Estado == eEstadoCursada.Cursando)
                {
                    if ((string)materia == nombreMateria)
                    {
                        materiaCursada = materia;
                    }
                }
            }
            if (materiaCursada == null)
            {
                throw (new Exception("El alumno no se encuentra cursando esta materia."));
            }
            return materiaCursada;
        }
        /// <summary>
        /// Devuelve un diccionario con todas las materias EN CURSO del alumno.
        /// </summary>
        public Dictionary<string, MateriaCursada> GetMateriasEnCurso()
        {
            Dictionary<string, MateriaCursada> materiasCursandoDict = new();
            foreach (MateriaCursada materia in _materiasCursadas)
            {
                if (materia.Estado == eEstadoCursada.Cursando)
                {
                    materiasCursandoDict.Add((string)materia, materia);
                }
            }
            return materiasCursandoDict;
        }
        /// <summary>
        /// Devuelve una lista con todas las materias EN CURSO del alumno.
        /// </summary>
        public List<MateriaCursada> GetMateriasEnCursoList()
        {
            List<MateriaCursada> materiasCursando = new();
            foreach (MateriaCursada materia in _materiasCursadas)
            {
                if (materia.Estado == eEstadoCursada.Cursando)
                {
                    materiasCursando.Add(materia);
                }
            }
            return materiasCursando;
        }
        /// <summary>
        /// Devuelve un diccionario con todas las materias cursadas por el alumno
        /// </summary>
        public Dictionary<string, MateriaCursada> GetMaterias()
        {
            Dictionary<string, MateriaCursada> materiasCursandoDict = new();
            foreach (MateriaCursada materia in _materiasCursadas)
            {
                materiasCursandoDict.Add((string)materia, materia);
            }
            return materiasCursandoDict;
        }
        /// <summary>
        /// Devuelve una lista de materias con todas las materias cursadas por el alumno.
        /// </summary>
        public List<MateriaCursada> GetMateriasList()
        {
            return _materiasCursadas;
        }
        /// <summary>
        /// Devuelve true o false dependiendo si el alumno esta actualmente cursando alguna materia.
        /// </summary>
        /// <returns>
        /// True = Esta cursando alguna materia, False = No esta cursando ninguna materia
        /// </returns>
        public bool EstaCursandoAlgo()
        {
            if (_materiasCursadas.Count == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica si el alumno ya está anotado en el máximo de materias posibles. De ser así, lanza excepción.
        /// </summary>
        public void PuedeInscribirse()
        {
            int materiasCursadasCount = 0;
            foreach (MateriaCursada materia in _materiasCursadas)
            {
                if (materia.Estado == eEstadoCursada.Cursando)
                {
                    materiasCursadasCount++;
                }
            }
            if (materiasCursadasCount >= 2)
            {
                throw new Exception("El alumno ya está cursando el maximo de materias");
            }
        }
    }
}
