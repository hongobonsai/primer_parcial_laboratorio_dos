using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alonso_nicolas_primer_parcial_labo.Clases.enums;
using Clases.enums;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Clases
{
    /// <summary>
    /// Esta clase representa a un profesor. Almacena los datos correspondientes al profesor.
    /// Hereda de Academico
    /// </summary>
    public sealed class Profesor : Academico
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        private List<string?> _materiasAsignadas;
        private List<Examen> _examenes;

        public Profesor(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero) : base(user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            _materiasAsignadas = new List<string?>();
            _examenes = new List<Examen>();
            _sqlConnection = new SqlConnection(@"
            Data Source = .;
            Database = parcial_dos;
            Trusted_Connection = True;
        ");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }
        public Profesor(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero, List<string?> materiasAsignadas) : this (user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            this._materiasAsignadas = materiasAsignadas;
        }
        public List<string?> MateriasAsignadas { get => _materiasAsignadas; set => _materiasAsignadas = value; }

        /// <summary>
        /// Valida que exista el nombre de materia recibido, Instancia una materia con los parametros recibidos, y llama al metodo "AgregarMateria", al que le pasa la materia instanciada anteriormente.
        /// </summary>
        public static Materia? NewMateria(string nombre, eCuatrimestre cuatrimestre, string correlativa)
        {
            Materia? retorno;
            if (nombre != "")
            {
                if (SysControl.ExistMateria(nombre) != true)
                {
                    Materia materia = new(nombre, cuatrimestre, correlativa);
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
        /// Crea y agrega un examen
        /// </summary>
        public static bool AgregarExamen(string nombre, string materia, DateTime fecha, string userProfesor)
        {
            bool retorno = false;
            int idProfesor;
            if (materia != "" && nombre != "" && fecha != null)
            {
                try
                {
                    if ((idProfesor = SysControl.GetProfesorId(userProfesor)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id del profesor");
                    }
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();

                    _sqlCommand.CommandText = "INSERT INTO Examenes (nombre, nombreMateria, fecha, profesorId) " +
                        "VALUES(@nombreExam, @nombreMat, @fech, @profId)";
                    _sqlCommand.Parameters.AddWithValue("@nombreExam", nombre);
                    _sqlCommand.Parameters.AddWithValue("@nombreMat", materia);
                    _sqlCommand.Parameters.AddWithValue("@fech", fecha);
                    _sqlCommand.Parameters.AddWithValue("@profId", idProfesor);
                    if (_sqlCommand.ExecuteNonQuery() == 0)
                    {
                        throw new Exception($"No se pudo agregar el examen {nombre}");
                    }
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    _sqlConnection.Close();
                }
            }
            else
            {
                throw new Exception($"Completar los datos requeridos");
            }
            return retorno;
        }
        /// <summary>
        /// Modifica la regularidad de la cursada del alumno recibido, en la materia recibida. Asigna la regularidad recibida por parametro.
        /// </summary>
        public static bool FinalizarCuatrimestre(string nombreUsuario, string nombreMateria, int notaPrimero, int notaSegundo)
        {
            bool retorno = false;
            int idAlumno = 0;
            int idMateria = 0;
            int promedio;
            try
            {
                if (nombreUsuario != "" && nombreMateria != "")
                {
                    if ((idAlumno = SysControl.GetAlumnoId(nombreUsuario)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id del alumno");
                    }
                    if ((idMateria = SysControl.GetMateriaId(nombreMateria)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id de la materia");
                    }
                    if (!SysControl.IsAlumnoInMateriaData(idAlumno, idMateria))
                    {
                        throw new Exception($"El alumno no está inscripto en esta materia");
                    }
                    if(!EsAlumnoRegular(idAlumno, nombreMateria, idMateria)){
                        throw new Exception($"El alumno no es Alumno Regular");
                    }
                    if (!TieneAsistencia(idAlumno, nombreMateria, idMateria))
                    {
                        throw new Exception($"El alumno no asistio a las clases");
                    }
                    promedio = Funcionalidades.SacarPromedio(notaPrimero, notaSegundo);
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();
                    _sqlCommand.CommandText = "UPDATE MateriaData SET notaPrimerParcial = @notaPP, notaSegundoParcial = @notaSP, " +
                                              "promedio = @notaProm, estado = @estado  WHERE idAlumno = @idAlum AND idMateria = @idMat";
                    _sqlCommand.Parameters.AddWithValue("@notaPP", notaPrimero);
                    _sqlCommand.Parameters.AddWithValue("@notaSP", notaSegundo);
                    _sqlCommand.Parameters.AddWithValue("@notaProm", promedio);
                    if (promedio > 6)
                    {
                        _sqlCommand.Parameters.AddWithValue("@estado", eEstadoCursada.Aprobada);
                    }
                    else
                    {
                        _sqlCommand.Parameters.AddWithValue("@estado", eEstadoCursada.Desaprobada);
                    }
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    if (_sqlCommand.ExecuteNonQuery() == 0)
                    {
                        throw new Exception($"No se pudo realizar la evaluacion");
                    }
                    if(promedio > 6)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
                else
                {
                    throw new Exception("Por favor, verificar los datos.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return retorno;
        }
        /// <summary>
        /// Verifica regularidad
        /// </summary>
        /// <returns>
        /// True si es regular, False si es libre
        /// </returns>
        public static bool EsAlumnoRegular(int idUsuario, string nombreMateria, int idMateria)
        {
            int regularidad = 1;
            bool retorno = false;
            try
            {
                if (SysControl.ExistMateria(nombreMateria) == true)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT regularidad FROM MateriaData WHERE idAlumno = @idAlum AND idMateria = @idMat";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idUsuario);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        regularidad = int.Parse(reader["regularidad"].ToString());
                    }
                    if(regularidad == 0)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    throw new Exception("La materia ingresada no existe.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Verifica Asistencia
        /// </summary>
        /// <returns>
        /// True si es regular, False si es libre
        /// </returns>
        public static bool TieneAsistencia(int idUsuario, string nombreMateria, int idMateria)
        {
            int asistencia = 1;
            bool retorno = false;
            try
            {
                if (SysControl.ExistMateria(nombreMateria) == true)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT asistencia FROM MateriaData WHERE idAlumno = @idAlum AND idMateria = @idMat";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idUsuario);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        asistencia = int.Parse(reader["asistencia"].ToString());
                    }
                    if (asistencia == 0)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    throw new Exception("La materia ingresada no existe.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Devuelve una lista con los examenes creados para la materia recibida. Los examenes y la materia deben pertenecer al profesor logueado.
        /// </summary>
        public static List<Examen>? GetExamenesMateria(string nombreMateria, string profesor)
        {
            List<Examen> examenesList = new();
            int idProfesor;
            if (nombreMateria != "")
            {
                if (SysControl.ExistMateria(nombreMateria) == true)
                {
                    try
                    {
                        if ((idProfesor = SysControl.GetProfesorId(profesor)) == 0)
                        {
                            throw new Exception($"No se pudo traer el id del profesor");
                        }
                        _sqlCommand.Parameters.Clear();
                        _sqlCommand.CommandText = "SELECT * FROM Examenes WHERE profesorId = @ProfId AND nombreMateria = @nombreMat";
                        _sqlCommand.Parameters.AddWithValue("@ProfId", idProfesor);
                        _sqlCommand.Parameters.AddWithValue("@nombreMat", nombreMateria);
                        _sqlConnection.Open();

                        SqlDataReader reader = _sqlCommand.ExecuteReader();

                        if (!(reader.HasRows))
                        {
                            throw new Exception($"La materia seleccionada no tiene examenes");
                        }

                        while (reader.Read())
                        {
                            Examen examen = (Examen)reader;

                            //Console.WriteLine(persona);
                            examenesList.Add(examen);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (_sqlConnection.State == System.Data.ConnectionState.Open)
                        {
                            _sqlConnection.Close();
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
        public static List<Alumno>? GetAlumnosMateriaProfesor(string nombreMateria, string nombreProfesor)
        {
            List<Alumno> alumnosList = new();
            int idMateria;
            int idProfesor;
            if (nombreMateria != "")
            {
                if (SysControl.ExistMateria(nombreMateria) == true)
                {
                    try
                    {
                        if ((idMateria = SysControl.GetMateriaId(nombreMateria)) == 0)
                        {
                            throw new Exception($"No se pudo traer el id de la materia");
                        }
                        if ((idProfesor = SysControl.GetProfesorId(nombreProfesor)) == 0)
                        {
                            throw new Exception($"No se pudo traer el id del profesor");
                        }
                        _sqlCommand.Parameters.Clear();
                        _sqlCommand.CommandText = "SELECT * FROM Academicos a JOIN MateriaData md ON a.academicoId = md.idAlumno JOIN MateriaProfesor mp ON md.idMateria = mp.idMateriaAsignada WHERE mp.idProfesor = @profId AND md.nombre = @nombreMat";
                        _sqlCommand.Parameters.AddWithValue("@profId", idProfesor);
                        _sqlCommand.Parameters.AddWithValue("@nombreMat", nombreMateria);
                        _sqlConnection.Open();

                        SqlDataReader reader = _sqlCommand.ExecuteReader();

                        if (!(reader.HasRows))
                        {
                            throw new Exception($"La materia seleccionada no tiene alumnos");
                        }

                        while (reader.Read())
                        {
                            Alumno alumno = (Alumno)reader;

                            //Console.WriteLine(persona);
                            alumnosList.Add(alumno);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (_sqlConnection.State == System.Data.ConnectionState.Open)
                        {
                            _sqlConnection.Close();
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
            return alumnosList;
        }
        public static explicit operator Profesor(SqlDataReader v)
        {
            Profesor p = new Profesor
                (
                v["usuario"].ToString() ?? "", v["contrasenia"].ToString() ?? "", (eType)v["tipoUsuario"],
                v["nombre"].ToString() ?? "", v["apellido"].ToString() ?? "", Convert.ToInt32(v["dni"]),
                (DateTime)v["fechaNacimiento"], (eGenero)v["genero"]
                );

            return p;
        }
    }
}
