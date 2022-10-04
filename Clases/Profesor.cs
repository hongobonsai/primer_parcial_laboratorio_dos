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
    /// Esta clase representa a un profesor. Almacena los datos correspondientes al profesor.
    /// Hereda de Academico
    /// </summary>
    public sealed class Profesor : Academico
    {
        private List<string?> _materiasAsignadas;
        private List<Examen> _examenes;

        public Profesor(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero) : base(user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            _materiasAsignadas = new List<string?>();
            _examenes = new List<Examen>();
        }
        public Profesor(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero, List<string?> materiasAsignadas) : this (user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            this._materiasAsignadas = materiasAsignadas;
        }
        public List<string?> MateriasAsignadas { get => _materiasAsignadas; set => _materiasAsignadas = value; }

        /// <summary>
        /// Valida que exista el nombre de materia recibido, Instancia una materia con los parametros recibidos, y llama al metodo "AgregarMateria", al que le pasa la materia instanciada anteriormente.
        /// </summary>
        public static Materia? NewMateria(string nombre, eCuatrimestre cuatrimestre)
        {
            Materia? retorno;
            if (nombre != "")
            {
                if (SysControl.ExistMateria(nombre) != true)
                {
                    Materia materia = new(nombre, cuatrimestre);
                    SysControl.AgregarMateria(materia);
                    retorno = materia;
                }
                else
                {
                    throw new Exception("La materia ingresada ya existe.");
                }
            }
            else
            {
                throw new Exception("Completar los campos requeridos.");
            }
            return retorno;
        }
        /// <summary>
        /// Valida que exista el nombre de materia recibido y valida que la fecha no haya pasado.
        /// Instancia un examen con los parametros recibidos, y agrega el examen a la lista de examenes de la materia.
        /// </summary>
        public Examen? NewExamen(string nombre, string materia, DateTime fecha)
        {
            Examen? retorno;
            if (nombre != "" && materia != "")
            {
                if (fecha >= DateTime.Now)
                {
                    if (SysControl.ExistMateria(materia) == true)
                    {
                        Examen examen = new(nombre, materia, fecha);
                        _examenes.Add(examen);
                        retorno = examen;
                    }
                    else
                    {
                        throw new Exception("La materia ingresada no existe.");
                    }
                }
                else
                {
                    throw new Exception("No se puede inscribir un parcial a una fecha que ya pasó");
                }
            }
            else
            {
                throw new Exception("Completar los campos requeridos.");
            }
            return retorno;
        }
        /// <summary>
        /// Finaliza la cursada de la materia del alumno, poniendole las notas correspondientes, sacando el promedio y otorgando la condicion de Aprobado/Desaprobado.
        /// </summary>
        public static bool FinalizarCuatrimestre(int dni, string materia, int notaPrimero, int notaSegundo)
        {
            int promedio;
            Alumno? alumno;
            MateriaCursada? materiaCursada;
            Materia? materiaObj;
            try
            {
                alumno = SysControl.GetAlumnoByDni(dni);
                materiaCursada = alumno.GetMateriaEnCurso(materia);
                materiaObj = SysControl.GetMateria(materia);
                promedio = Funcionalidades.SacarPromedio(notaPrimero, notaSegundo);
                if(materiaCursada.Estado == eEstadoCursada.Cursando)
                {
                    if (materiaCursada.Regularidad == eRegularidad.Regular)
                    {
                        if(materiaCursada.Asistencia == eAsistencia.Presente)
                        {
                            if (notaPrimero > 6 && notaSegundo > 6)
                            {
                                materiaCursada.Estado = eEstadoCursada.Aprobada;
                                materiaObj.Alumnos.Remove(alumno);
                                materiaCursada.NotaPrimerParcial = notaPrimero;
                                materiaCursada.NotaSegundoParcial = notaSegundo;
                                materiaCursada.NotaFinal = promedio;
                                return true;
                            }
                            else
                            {
                                materiaCursada.Estado = eEstadoCursada.Desaprobada;
                                materiaObj.Alumnos.Remove(alumno);
                                materiaCursada.NotaPrimerParcial = notaPrimero;
                                materiaCursada.NotaSegundoParcial = notaSegundo;
                                materiaCursada.NotaFinal = promedio;
                                return false;
                            }
                        }
                        else
                        {
                            throw (new Exception("El alumno no asistió a ninguna clase."));
                        }
                    }
                    else
                    {
                        throw (new Exception("El alumno quedó libre, no puede ser evaluado."));
                    }
                } else
                {
                    throw (new Exception("Actualmente no se está cursando esta materia."));
                }
            }
            catch (Exception ex)
            {
                throw(new Exception($"{ex.Message}"));
            }
        }
        /// <summary>
        /// Devuelve una lista con los examenes creados para la materia recibida. Los examenes y la materia deben pertenecer al profesor logueado.
        /// </summary>
        public List<Examen>? GetExamenesMateria(string nombreMateria)
        {
            List<Examen>? examenesList = new();
            if (nombreMateria != "")
            {
                if (SysControl.ExistMateria(nombreMateria) == true)
                {
                    foreach (Examen examen in _examenes)
                    {
                        if(examen.Materia == nombreMateria)
                        {
                            examenesList.Add(examen);
                        }
                    }
                }
                else
                {
                    throw new Exception("La materia ingresada no existe.");
                }
            }
            else
            {
                throw new Exception("Completar los campos requeridos.");
            }
            return examenesList;
        }
    }
}
