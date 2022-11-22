using Clases;
using Clases.enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clases
{
    /// <summary>
    /// Clase estatica que actúa de "base de datos" del sistema. Almacena todos los datos y sus metodos permiten interactuar con los mismos.
    /// </summary>
    public static class SysControl
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static Dictionary<string, Usuario?> _usuariosDict;
        static Dictionary<string, Materia?> _materiasDict;
        static SysControl()
        {
            _usuariosDict = new Dictionary<string, Usuario?>();
            _materiasDict = new Dictionary<string, Materia?>();

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
        /// Verifica si el user recibido corresponde al nombre de usuario de algun Usuario.
        /// </summary>
        public static bool ExistUsuario(string user)
        {
            bool retorno = false;
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT usuario FROM Academicos WHERE usuario = @user";
                _sqlCommand.Parameters.AddWithValue("@user", user);
                _sqlConnection.Open();
                try
                {
                    if (_sqlCommand.ExecuteScalar() != null)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Verifica si algún usuario ya fue ingresado con el dni recibido.
        /// </summary>
        /// <returns>
        /// true si el dni ya existe, false si no existe
        /// </returns>
        public static bool ExistsDni(int dni)
        {
            bool retorno = false;
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT usuario FROM Academicos WHERE dni = @dni";
                _sqlCommand.Parameters.AddWithValue("@dni", dni);
                _sqlConnection.Open();
                try
                {
                    if (_sqlCommand.ExecuteScalar() != null)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Agrega un Usuario recibido por parametro al diccionario de usuarios del sistema
        /// </summary>
        /// <returns>
        /// true si OK, false si ERROR
        /// </returns>
    public static bool AgregarUsuario(Usuario usuario)
        {
            bool retorno = false;
            if (usuario != null)
            {
                try
                {
                    Academico acaBuff = (Academico)usuario;
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();
                    if(usuario.tipoUsuario == eType.Admin)
                    {
                        _sqlCommand.CommandText = "INSERT INTO Academicos (usuario, contrasenia, tipoUsuario) VALUES(@user, @pass, @tipo)";
                        _sqlCommand.Parameters.AddWithValue("@user", usuario.User);
                        _sqlCommand.Parameters.AddWithValue("@pass", usuario.GetPass());
                        _sqlCommand.Parameters.AddWithValue("@tipo", usuario.tipoUsuario);
                        if (_sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new Exception($"No se pudo agregar al {usuario.tipoUsuario}");
                        }

                    } else if(usuario.tipoUsuario == eType.Alumno || usuario.tipoUsuario == eType.Profesor)
                    {
                        _sqlCommand.CommandText = "INSERT INTO Academicos (dni, tipoUsuario, usuario, contrasenia, nombre, " +
                            "apellido, fechaNacimiento, genero) " +
                            "VALUES(@dni, @type, @user, @pass, @nombre, @apellido, @nacimiento, @genero)";
                        _sqlCommand.Parameters.AddWithValue("@dni", acaBuff.Dni);
                        _sqlCommand.Parameters.AddWithValue("@type", acaBuff.tipoUsuario);
                        _sqlCommand.Parameters.AddWithValue("@user", acaBuff.User);
                        _sqlCommand.Parameters.AddWithValue("@pass", acaBuff.GetPass());
                        _sqlCommand.Parameters.AddWithValue("@nombre", acaBuff.Nombre);
                        _sqlCommand.Parameters.AddWithValue("@apellido", acaBuff.Apellido);
                        _sqlCommand.Parameters.AddWithValue("@nacimiento", acaBuff.Nacimiento);
                        _sqlCommand.Parameters.AddWithValue("@genero", acaBuff.Genero);
                        if (_sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new Exception($"No se pudo agregar al {usuario.tipoUsuario}");
                        }
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Obtiene el tipo de usuario en formato "eType", correspondiente al string recibido
        /// </summary>
        /// <returns>
        /// Tipo de usuario en formato "eType"
        /// </returns>
        public static eType GetTipoUsuario(string? type)
        {
            eType retorno = eType.Alumno;
            if (type == "Profesor")
            {
                retorno = eType.Profesor;
            }
            return retorno;
        }
        /// <summary>
        /// Devuelve un diccionario de usuarios del sistema
        /// </summary>
        public static Dictionary<string, Usuario?> GetUsuarios()
        {
            Dictionary<string, Usuario> userDict = new Dictionary<string, Usuario>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario persona = (Usuario)reader;

                    //Console.WriteLine(persona);
                    userDict.Add(persona.User, persona);
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

            return userDict;
        }
        /// <summary>
        /// Obtiene cada usuario del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de usuarios del sistema
        /// </summary>
        public static List<Usuario> GetUsuariosList()
        {
            List<Usuario> userList = new List<Usuario>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario persona = (Usuario)reader;
                    userList.Add(persona);
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
            return userList;
        }
        /// <summary>
        /// Obtiene cada admin del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de admins del sistema
        /// </summary>
        public static List<Admin> GetAdminsList()
        {
            List<Admin> adminList = new List<Admin>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos WERE tipoUsuario = 0";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Admin persona = (Admin)reader;

                    //Console.WriteLine(persona);
                    adminList.Add(persona);
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

            return adminList;
        }
        /// <summary>
        /// Devuelve un diccionario de profesores del sistema
        /// </summary>
        public static Dictionary<string, Usuario?> GetProfesores()
        {
            Dictionary<string, Usuario> profesoresDict = new Dictionary<string, Usuario>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos WHERE tipoUsuario = 1";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario persona = (Usuario)reader;

                    //Console.WriteLine(persona);
                    profesoresDict.Add(persona.User, persona);
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

            return profesoresDict;
        }
        /// <summary>
        /// Obtiene cada profesor del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de profesores del sistema
        /// </summary>
        public static List<Profesor> GetProfesoresList()
        {
            List<Profesor> profesoresList = new List<Profesor>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos WHERE tipoUsuario = 1";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Profesor persona = (Profesor)reader;

                    //Console.WriteLine(persona);
                    profesoresList.Add(persona);
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

            return profesoresList;
        }
        /// <summary>
        /// Obtiene cada materia del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de materias del sistema
        /// </summary>
        public static Dictionary<string, Materia> GetMateriasProfesorDict(string usuarioProfesor)
        {
            Dictionary<string, Materia> materiasList = new Dictionary<string, Materia>();
            int idProfesor;
            try
            {
                if ((idProfesor = SysControl.GetProfesorId(usuarioProfesor)) == 0)
                {
                    throw new Exception($"No se pudo traer el id del profesor");
                }
                _sqlCommand.CommandText = "SELECT * FROM Materias m JOIN MateriaProfesor mp ON m.id = mp.idMateriaAsignada WHERE idProfesor = @idProf";
                _sqlCommand.Parameters.AddWithValue("@idProf", idProfesor);
                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Materia materia = (Materia)reader;

                        //Console.WriteLine(persona);
                        materiasList.Add(materia.Nombre, materia);
                    }
                } else
                {
                    throw new Exception("El profesor no tiene materias asignadas");
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

            return materiasList;
        }
        /// <summary>
        /// Llama a GetMateriasProfesor, y convierte ese diccionario de materias del profesor en una lista.
        /// </summary>
        /// <returns>
        /// La lista con todas las materias obtenidas
        /// </returns>
        /// 
        public static List<Materia> GetMateriasProfesorList(string usuarioProfesor)
        {
            List<Materia> materiasList = new List<Materia>();
            int idProfesor;
            try
            {
                if ((idProfesor = SysControl.GetProfesorId(usuarioProfesor)) == 0)
                {
                    throw new Exception($"No se pudo traer el id del profesor");
                }
                _sqlCommand.CommandText = "SELECT * FROM Materias m JOIN MateriaProfesor mp ON m.id = mp.idMateriaAsignada WHERE idProfesor = @idProf";
                _sqlCommand.Parameters.AddWithValue("@idProf", idProfesor);
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Materia materia = (Materia)reader;

                        //Console.WriteLine(persona);
                        materiasList.Add(materia);
                    }
                }
                else
                {
                    throw new Exception("El profesor no tiene materias asignadas");
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
            return materiasList;
        }
        /// <summary>
        /// Obtiene cada alumno del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de alumnos del sistema
        /// </summary>
        public static List<Alumno> GetAlumnosList()
        {
            List<Alumno> alumnosList = new List<Alumno>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Academicos WHERE tipoUsuario = 2";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Alumno persona = (Alumno)reader;

                    //Console.WriteLine(persona);
                    alumnosList.Add(persona);
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
            return alumnosList;
        }
        /// <summary>
        /// Obtiene el alumno correspondiente al dni recibido por parametro.
        /// </summary>
        /// <returns>
        /// El alumno obtenido.
        /// </returns>
        public static Alumno? GetAlumnoByDni(int dni)
        {
            Alumno ? alumnoEncontrado = null;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM Academicos WHERE dni = @dniAlum";
                _sqlCommand.Parameters.AddWithValue("@dniAlum", dni);
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    alumnoEncontrado = (Alumno)reader;
                }
                if (alumnoEncontrado == null)
                {
                    throw (new Exception("El dni ingresado no corresponde a un alumno."));
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
            return alumnoEncontrado;
        }
        /// <summary>
        /// Devuelve un diccionario con todas las materias del sistema.
        /// </summary>
        public static Dictionary<string, Materia?> GetMaterias()
        {
            Dictionary<string, Materia> materiasDict = new Dictionary<string, Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Materias";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;

                    //Console.WriteLine(persona);
                    materiasDict.Add(materia.Nombre, materia);
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

            return materiasDict;
        }
        /// <summary>
        /// Obtiene cada materia del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de materias del sistema
        /// </summary>
        public static List<Materia> GetMateriasList()
        {
            List<Materia> materiasList = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Materias";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;

                    //Console.WriteLine(persona);
                    materiasList.Add(materia);
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

            return materiasList;
        }
        /// <summary>
        /// Obtiene la materia correspondiente al nombre de materia recibido por parametro.
        /// </summary>
        /// <returns>
        /// La materia obtenida.
        /// </returns>
        public static Materia? GetMateria(string nombreMateria)
        {
            Materia? materiaBuff = null;
            try
            {
                if (ExistMateria(nombreMateria) == true)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT * FROM Materias WHERE nombre = @nombreMate";
                    _sqlCommand.Parameters.AddWithValue("@nombreMate", nombreMateria);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        materiaBuff = (Materia)reader;
                    }
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
            return materiaBuff;
        }
        /// <summary>
        /// Agrega el objeto materia recibido por parametro, al diccionario de materias del sistema.
        /// </summary>
        public static bool AgregarMateria(Materia materia)
        {
            bool retorno = false;
            int materiaId = 0;
            if (materia != null)
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();

                    _sqlCommand.CommandText = "INSERT INTO Materias (nombre, cuatrimestre) VALUES(@nombreMateria, @cuatri)";
                    _sqlCommand.Parameters.AddWithValue("@nombreMateria", materia.Nombre);
                    _sqlCommand.Parameters.AddWithValue("@cuatri", materia.Cuatrimestre);
                    if (_sqlCommand.ExecuteNonQuery() == 0)
                    {
                        throw new Exception($"No se pudo agregar la materia {materia.Nombre}");
                    }
                    _sqlConnection.Close(); //Cierro la conexión para que no quede abierta al GetMateria
                    materiaId = GetMateriaId(materia.Nombre);
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open(); //Cierro la conexión para que no quede abierta al GetMateria
                    if (materia.Correlativa != "Ninguna")
                    {
                        _sqlCommand.CommandText = "UPDATE Materias SET correlativa = @correl WHERE id = @idMat";
                        _sqlCommand.Parameters.AddWithValue("@correl", materia.Correlativa);
                        _sqlCommand.Parameters.AddWithValue("@idMat", materiaId);
                    } else
                    {
                        _sqlCommand.CommandText = "UPDATE Materias SET correlativa = @correl WHERE id = @idMat";
                        _sqlCommand.Parameters.AddWithValue("@correl", "Ninguna");
                        _sqlCommand.Parameters.AddWithValue("@idMat", materiaId);
                    }
                    if (_sqlCommand.ExecuteNonQuery() == 0)
                    {
                        throw new Exception($"No se pudo agregar la correlativa {materia.Correlativa}");
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el string recibido por parametro corresponde a una materia existente
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        /// <summary>
        /// Verifica si la materia recibida corresponde al nombre de alguna materia existente.
        /// </summary>
        public static bool ExistMateria(string nombreMateria)
        {
            bool retorno = false;
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT nombre FROM Materias WHERE nombre = @nombreMat";
                _sqlCommand.Parameters.AddWithValue("@nombreMat", nombreMateria);
                _sqlConnection.Open();
                try
                {
                    if (_sqlCommand.ExecuteScalar() != null)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Asigna un profesor a una materia existente. Carga la materia en el campo _materiasAsignadas del profesor correspondiente. Carga el profesor en la lista de profesores de la materia.
        /// </summary>
        public static bool AsignarProfesor(Materia materiaBuff, string userProfesor)
        {
            bool retorno = false;
            int idProfesor;
            int idMateria;
            if (materiaBuff != null && userProfesor != "")
            {
                try
                {
                    if((idProfesor = GetProfesorId(userProfesor)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id del profesor");
                    }
                    if ((idMateria = GetMateriaId(materiaBuff.Nombre)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id de la materia");
                    }
                    if(IsProfesorInMateria(userProfesor, materiaBuff.Nombre))
                    {
                        throw new Exception($"El profesor ya está asignado a la materia");
                    }
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();

                    _sqlCommand.CommandText = "INSERT INTO MateriaProfesor (idProfesor, idMateriaAsignada) VALUES(@idProf, @idMat)";
                    _sqlCommand.Parameters.AddWithValue("@idProf", idProfesor);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    if (_sqlCommand.ExecuteNonQuery() < 1)
                    {
                        throw new Exception($"No se pudo asignar el profesor {userProfesor} a {materiaBuff.Nombre}");
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
            } else
            {
                throw new Exception("Verificar los campos ingresados");
            }
            return retorno;

        }
        /// <summary>
        /// Obtiene el id del profesor recibido
        /// </summary>
        /// <returns>
        /// Id en formato int
        /// </returns>
        public static int GetProfesorId(string userProfesor)
        {
            int idProfesor = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                if (ExistProfesor(userProfesor) == true)
                {
                    _sqlCommand.CommandText = "SELECT academicoId FROM Academicos WHERE usuario = @usuarioProfesor";
                    _sqlCommand.Parameters.AddWithValue("@usuarioProfesor", userProfesor);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        idProfesor = int.Parse(reader["academicoId"].ToString());
                    }
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
            return idProfesor;
        }
        /// <summary>
        /// Obtiene el id del profesor recibido
        /// </summary>
        /// <returns>
        /// Id en formato int
        /// </returns>
        public static int GetAlumnoId(string userAlumno)
        {
            int idAlumno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                if (ExistAlumno(userAlumno) == true)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT academicoId FROM Academicos WHERE usuario = @usuarioAlumno";
                    _sqlCommand.Parameters.AddWithValue("@usuarioAlumno", userAlumno);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        idAlumno = int.Parse(reader["academicoId"].ToString());
                    }
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
            return idAlumno;
        }
        /// <summary>
        /// Verifica si el string recibido por parametro corresponde a un profesor existente
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool ExistProfesor(string userProfesor)
        {
            bool retorno = false;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT usuario FROM Academicos WHERE usuario = @userProf AND tipoUsuario = 1";
                    _sqlCommand.Parameters.AddWithValue("@userProf", userProfesor);
                    _sqlConnection.Open();
                    if (_sqlCommand.ExecuteScalar() != null)
                    {
                        retorno = true;
                    } else
                    {
                        throw new Exception("El usuario ingresado no corresponde a ningún profesor");
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el string recibido por parametro corresponde a un alumno existente
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool ExistAlumno(string userAlumno)
        {
            bool retorno = false;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT usuario FROM Academicos WHERE usuario = @userAlum AND tipoUsuario = 2";
                    _sqlCommand.Parameters.AddWithValue("@userAlum", userAlumno);
                    _sqlConnection.Open();
                    if (_sqlCommand.ExecuteScalar() != null)
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new Exception("El usuario ingresado no corresponde a ningún alumno");
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el profesor ya está asignado a la materia
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool IsProfesorInMateria(string userProfesor, string nombreMateria)
        {
            bool retorno = false;
            int idProfesor = 0;
            int idMateria = 0;
            int idTablaIntermedia = 0;
            {
                try
                {
                    if ((idProfesor = GetProfesorId(userProfesor)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id del profesor");
                    }
                    if ((idMateria = GetMateriaId(nombreMateria)) == 0)
                    {
                        throw new Exception($"No se pudo traer el id de la materia");
                    }
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT idMateriaProfesor FROM MateriaProfesor WHERE idProfesor = @idProfesor AND idMateriaAsignada = @idMateria";
                    _sqlCommand.Parameters.AddWithValue("@idProfesor", idProfesor);
                    _sqlCommand.Parameters.AddWithValue("@idMateria", idMateria);
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();
                    //innecesario lo siguiente creo
                    while (reader.Read())
                    {
                        idTablaIntermedia = int.Parse(reader["idMateriaProfesor"].ToString());
                    }
                    if (reader.HasRows)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el alumno esta cursando
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool IsAlumnoInMateriaData(int idAlumno, int idMateria)
        {
            bool retorno = false;
            int idTablaIntermedia = 0;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT idAlumno FROM MateriaData WHERE idAlumno = @idAlum AND idMateria = @idMat AND estado = 2";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el alumno esta cursando al menos 1 materia
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool EstaCursandoAlumno(int idAlumno)
        {
            bool retorno = false;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT idAlumno FROM MateriaData WHERE idAlumno = @idAlum AND estado = 2";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el alumno esta cursando
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool AproboLaMateria(int idAlumno, int idMateria)
        {
            bool retorno = false;
            int idTablaIntermedia = 0;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT idAlumno FROM MateriaData WHERE idAlumno = @idAlum AND idMateria = @idMat AND estado = 0";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlCommand.Parameters.AddWithValue("@idMat", idMateria);
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Verifica si el alumno esta cursando
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool AproboCorrelativa(int idAlumno, string nombreCorrelativa)
        {
            bool retorno = false;
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT estado FROM MateriaData WHERE idAlumno = @idAlum AND nombre = @nombreCorr AND estado = 0";
                    _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                    _sqlCommand.Parameters.AddWithValue("@nombreCorr", nombreCorrelativa);
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        retorno = true;
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
            return retorno;
        }
        /// <summary>
        /// Obtiene el id de la materia recibida
        /// </summary>
        /// <returns>
        /// Id en formato int
        /// </returns>
        public static int GetMateriaId(string nombreMateria)
        {
            int idMateria = 0;
            try
            {
                if (ExistMateria(nombreMateria) == true)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = "SELECT id FROM Materias WHERE nombre = @nombreMat";
                    _sqlCommand.Parameters.AddWithValue("@nombreMat", nombreMateria);
                    _sqlConnection.Open();

                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        idMateria = int.Parse(reader["id"].ToString());
                    }
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
            return idMateria;
        }
        /// <summary>
        /// Obtiene cada materia del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de materias del sistema
        /// </summary>
        public static List<MateriaCursada> GetMateriasAlumnoList(string usuarioAlumno)
        {
            List<MateriaCursada> materiasList = new List<MateriaCursada>();
            int idAlumno;
            try
            {
                if ((idAlumno = SysControl.GetAlumnoId(usuarioAlumno)) == 0)
                {
                    throw new Exception($"No se pudo traer el id del alumno");
                }
                _sqlCommand.CommandText = "SELECT * FROM MateriaData WHERE idAlumno = @idAlum";
                _sqlCommand.Parameters.AddWithValue("@idAlum", idAlumno);
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    MateriaCursada materia = (MateriaCursada)reader;

                    //Console.WriteLine(persona);
                    materiasList.Add(materia);
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

            return materiasList;
        }
        public static List<Alumno>? GetAlumnosMateria(string nombreMateria)
        {
            List<Alumno> alumnosList = new();
            int idMateria;
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
                        _sqlCommand.Parameters.Clear();
                        _sqlCommand.CommandText = "SELECT * FROM Academicos a JOIN MateriaData md ON a.academicoId = md.idAlumno JOIN MateriaProfesor mp ON md.idMateria = mp.idMateriaAsignada WHERE md.nombre = @nombreMat";
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
        /// <summary>
        /// Obtiene el cuatrimestre en formato "eCuatrimestre", correspondiente al string recibido
        /// </summary>
        /// <returns>
        /// Cuatrimestre en formato "eCuatrimestre"
        /// </returns>
        public static eCuatrimestre GetCuatrimestre(string? cuatri)
        {
            eCuatrimestre retorno = eCuatrimestre.Primero;
            if (cuatri == "Segundo")
            {
                retorno = eCuatrimestre.Segundo;
            }
            return retorno;
        }
    }
}