using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
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
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        public Alumno()
        {

        }
        public Alumno(string? user, string? pass, eType type, string? nombre, string? apellido, int dni,
            DateTime nacimiento, eGenero genero) : base(user, pass, type, nombre, apellido, dni, nacimiento, genero)
        {
            _sqlConnection = new SqlConnection(@"
                    Data Source = .;
                    Database = parcial_dos;
                    Trusted_Connection = True;
                    ");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }
        /// <summary>
        /// Inscribe a un alumno en la materia obtenida a partir del nombre recibido por parametro.
        /// Busca la materia correspondiente en la lista de materias, y en caso que el alumno cumpla las condiciones (tenga aprobada la correlativa y no la este cursando/ya la haya aprobado), lo agrega a la lista.
        /// </summary>
        public static bool? InscribirseMateria(string? nombreMateria, Alumno alumno)
        {
            // crear materiadata
            bool retorno = false;

            int idAlumno;
            int idMateria;
            Materia materiaBuff = SysControl.GetMateria(nombreMateria);
            if (nombreMateria != "" && alumno != null)
            {
                try
                {
                    if ((idAlumno = SysControl.GetAlumnoId(alumno.User)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id del alumno");
                    }
                    if ((idMateria = SysControl.GetMateriaId(nombreMateria)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id de la materia");
                    }
                    if (SysControl.IsAlumnoInMateriaData(idAlumno, idMateria))
                    {
                        throw new Exception($"El alumno ya está inscripto");
                    }
                    if (SysControl.AproboLaMateria(idAlumno, idMateria))
                    {
                        throw new Exception($"El alumno ya aprobó la materia");
                    }
                    if (materiaBuff.Correlativa != "Ninguna")
                    {
                        if (!SysControl.AproboCorrelativa(idAlumno, materiaBuff.Correlativa))
                        {
                            throw new Exception($"El alumno no aprobó la correlativa correspondiente");
                        }
                    }
                    PuedeInscribirse(idAlumno);

                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();

                    _sqlCommand.CommandText = "INSERT INTO MateriaData (regularidad, asistencia, estado, nombre, idAlumno, idMateria) " +
                        "VALUES(@regu, @asist, @estado, @nombre, @idAlum, @idMat)";
                    _sqlCommand.Parameters.AddWithValue("@regu", eRegularidad.Regular);
                    _sqlCommand.Parameters.AddWithValue("@asist", eAsistencia.Ausente);
                    _sqlCommand.Parameters.AddWithValue("@estado", eEstadoCursada.Cursando);
                    _sqlCommand.Parameters.AddWithValue("@nombre", nombreMateria);
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    if (_sqlCommand.Parameters.Count < 6)
                    {
                        throw new Exception($"No se pudo asignar el alumno {alumno.User} a {nombreMateria}");
                    }
                    _sqlCommand.ExecuteNonQuery();
                    retorno = true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }
                finally
                {
                    _sqlConnection.Close();
                }
            }
            else
            {
                throw new Exception("Verificar los campos ingresados");
            }
            return retorno;
        }
            /// <summary>
            /// Carga la asistencia recibida por parametro en el atributo _asistencia de la Materia Cursada del alumno.
            /// </summary>
        public static void PresentarAsistencia(string nombreUsuario, string? nombreMateria, eAsistencia asistencia)
        {
            int idAlumno;
            int idMateria;
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
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();
                }
                else
                {
                    throw new Exception("Por favor, verificar los datos.");
                }
                _sqlCommand.CommandText = "UPDATE MateriaData SET asistencia = @asist WHERE idAlumno = @idAlum AND idMateria = @idMat";
                _sqlCommand.Parameters.AddWithValue("@asist", asistencia);
                _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                if (_sqlCommand.ExecuteNonQuery() == 0)
                {
                    throw new Exception($"No se pudo modificar la asistencia");
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
        }
        /// <summary>
        /// Verifica si el alumno ya está anotado en el máximo de materias posibles. De ser así, lanza excepción.
        /// </summary>
        public static void PuedeInscribirse(int idAlumno)
        {
            int CountCursadas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT COUNT(*) MateriasCursadas FROM MateriaData WHERE idAlumno " +
                    "= @idAlum AND estado = 2";
                _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                reader.Read();
                CountCursadas = int.Parse(reader["MateriasCursadas"].ToString());
                if(CountCursadas >= 2)
                {
                    throw new Exception($"El alumno ya está cursando el máximo de materias");
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
        }
        public static explicit operator Alumno(SqlDataReader v)
        {
            Alumno p = new Alumno
                (
                v["usuario"].ToString() ?? "", v["contrasenia"].ToString() ?? "", (eType)v["tipoUsuario"],
                v["nombre"].ToString() ?? "", v["apellido"].ToString() ?? "", Convert.ToInt32(v["dni"]),
                (DateTime)v["fechaNacimiento"], (eGenero)v["genero"]
                );

            return p;
        }
    }
}
