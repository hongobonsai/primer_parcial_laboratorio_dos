using alonso_nicolas_primer_parcial_labo.Clases.enums;
using Clases.enums;
using System.Data.SqlClient;

namespace Clases
{
    public sealed class Admin : Usuario
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        /// <summary>
        /// Esta clase representa a un administrador del sistema.
        /// Hereda de Usuario
        /// </summary>
        public Admin(string? user, string? pass, eType type) : base(user, pass, type)
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
        /// Valida usuario y contraseña, Instancia un Admin con los parametros recibidos, y llama al metodo "AgregarUsuario", al que le pasa el admin instanciado anteriormente.
        /// </summary>
        public static void NewAdmin(string user, string pass)
        {
            if (user != "" && pass != "")
            {
                if (SysControl.ExistUsuario(user) != true)
                {
                    Admin admin = new(user, pass, eType.Admin);
                    SysControl.AgregarUsuario(admin);
                }
                else
                {
                    throw new Exception("El usuario ingresado ya existe.");
                }
            }
            else
            {
                throw new Exception("Completar los campos requeridos.");
            }
        }
        /// <summary>
        /// Valida datos de academico recibidos, Instancia un Alumno o un Profesor, dependiendo el eType del Academico, y llama al metodo "AgregarUsuario", al que le pasa el Alumno o Profesor según corresponda.
        /// </summary>
        public static void NewAcademico(string? user, string? pass, eType type, string? nombre, string? apellido, string? dniStr, DateTime nacimiento, eGenero genero)
        {
            int dni;
            if (SysControl.ExistUsuario(user) != true)
            {
                try
                {
                    Academico.ValidarDatosAcademico(user, pass, type, nombre, apellido, dniStr, nacimiento, genero);
                    dni = int.Parse(dniStr);
                    if (SysControl.ExistsDni(dni))
                    {
                        throw new Exception("El DNI ingresado ya existe.");
                    }
                    else
                    {
                        if (type == eType.Alumno)
                        {
                            Alumno alumno = new(user, pass, type, nombre, apellido, dni, nacimiento, genero);
                            SysControl.AgregarUsuario(alumno);
                        }
                        else if (type == eType.Profesor)
                        {
                            Profesor profesor = new(user, pass, type, nombre, apellido, dni, nacimiento, genero);
                            SysControl.AgregarUsuario(profesor);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }
            }
            else
            {
            throw new Exception("El usuario ingresado ya existe.");
            }
        }
        /// <summary>
        /// Modifica la regularidad de la cursada del alumno recibido, en la materia recibida. Asigna la regularidad recibida por parametro.
        /// </summary>
        public static void CambiarRegularidad(Alumno? alumno, string nombreMateria, eRegularidad regularidad)
        {
            int idAlumno = 0;
            int idMateria = 0;
            try
            {
                if (alumno != null && nombreMateria != "")
                {
                    if ((idAlumno = SysControl.GetAlumnoId(alumno.User)) == 0)
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
                _sqlCommand.CommandText = "UPDATE MateriaData SET regularidad = @regularidad WHERE idAlumno = @idAlum AND idMateria = @idMat";
                _sqlCommand.Parameters.AddWithValue("@regularidad", regularidad);
                _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                if (_sqlCommand.ExecuteNonQuery() == 0)
                {
                    throw new Exception($"No se pudo modificar la regularidad");
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


        public static explicit operator Admin(SqlDataReader v)
        {
            Admin p = new Admin(v["usuario"].ToString() ?? "", v["contrasenia"].ToString() ?? "", (eType)v["tipoUsuario"]);

            return p;
        }

    }
}