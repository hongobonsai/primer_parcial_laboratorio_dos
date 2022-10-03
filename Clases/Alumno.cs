using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.enums;

namespace Clases
{
    public class Alumno : Academico
    {
        private List<MateriaCursada>? _materiasCursadas;

        public Alumno(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero) : base(user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            _materiasCursadas = new();
        }
        public List<MateriaCursada>? MateriasActuales
        {
            get { return _materiasCursadas; }
            set { _materiasCursadas = value; }
        }

        public static MateriaCursada? InscribirseMateria(string? nombreMateria, Alumno alumno)
        {
            MateriaCursada retorno = null;
            Materia? materiaBuff;
            MateriaCursada materiaInscribirse;
            bool aproboCorrelativa = true;
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
                    if (materiaBuff.Correlativa != "Ninguna")
                    {
                        aproboCorrelativa = false;
                        foreach (MateriaCursada materia in alumno._materiasCursadas)
                        {
                            if (materia.Nombre == materiaBuff.Nombre)
                            {
                                if(materia.Estado == eEstadoCursada.Aprobada)
                                {
                                    aproboCorrelativa = true;
                                }
                            }
                        }
                    }
                    if (aproboCorrelativa == false)
                    {
                        throw new Exception("El alumno no aprobó la correlativa correspondiente.");
                    }
                    materiaBuff.Alumnos.Add(alumno);
                    materiaInscribirse = new(nombreMateria, eRegularidad.Regular, eEstadoCursada.Cursando);
                    alumno.MateriasActuales.Add(materiaInscribirse);
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
        public bool PresentarAsistencia(string? nombreMateria, eAsistencia asistencia)
        {
            MateriaCursada? materiaBuff;
                materiaBuff = GetMateriaEnCurso(nombreMateria);
                materiaBuff.Asistencia = asistencia;

            return true;
        }
        public MateriaCursada? GetMateriaEnCurso(string? nombreMateria)
        {
            MateriaCursada? materiaCursada = null;
            foreach (MateriaCursada? materia in _materiasCursadas)
            {
                if (materia.Nombre == nombreMateria)
                {
                    materiaCursada = materia;
                }
            }
            if (materiaCursada == null)
            {
                throw (new Exception("El alumno no se encuentra cursando esta materia."));
            }
            return materiaCursada;
        }
        // sobrecargar (int)Alumno (o similar) para que te devuelva la nota del alumno
    }
}
