using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.enums;

namespace Clases
{
    public class Profesor : Academico
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
        public static bool FinalizarCuatrimestre(int dni, string materia, int notaPrimero, int notaSegundo)
        {
            int promedio;
            Alumno? alumno;
            MateriaCursada? materiaCursada;
            try
            {
                alumno = SysControl.GetAlumnoByDni(dni);
                materiaCursada = alumno.GetMateriaEnCurso(materia);
                promedio = SacarPromedio(notaPrimero, notaSegundo);
                if(materiaCursada.Estado == eEstadoCursada.Cursando)
                {
                    if (materiaCursada.Regularidad == eRegularidad.Regular)
                    {
                        if(promedio > 6)
                        {
                            materiaCursada.Estado = eEstadoCursada.Aprobada;
                            return true;
                        } else
                        {
                            materiaCursada.Estado = eEstadoCursada.Desaprobada;
                            return false;
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
        public static int SacarPromedio(int notaPrimero, int notaSegundo)
        {
            int promedio;
            if ((notaPrimero >= 1 && notaPrimero <= 10) && (notaSegundo >= 1 && notaSegundo <= 10))
            {
                promedio = notaPrimero / notaSegundo;
            }
            else
            {
                throw (new Exception("Los valores ingresados deben estar entre 1 y 10"));
            }
            return promedio;
        }
    }
}
