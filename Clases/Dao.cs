using Clases.enums;
using Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo.Clases
{
    internal class SystemDao
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static Dictionary<string, Usuario?> _usuariosDict;
        static Dictionary<string, Materia?> _materiasDict;

        static SystemDao()
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
        /// Valida los datos de login de usuario recibidos por parametro. Tambien devuelve el Usuario que corresponde al user recibido.
        /// </summary>
        public static Usuario? LoginCheck(string user, string pass, eType tipoUsuario)
        {
            Usuario? retorno = null;
            Usuario? buffUser;
            if (user != "" && pass != "")
            {
                try
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = $"SELECT * FROM Academicos WHERE usuario = '{user}'";
                    _sqlConnection.Open();
                    SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = null;
                        switch (tipoUsuario)
                        {
                            case eType.Alumno:
                                usuario = (Alumno)reader;
                                break;
                            case eType.Profesor:
                                usuario = (Profesor)reader;
                                break;
                            case eType.Admin:
                                usuario = (Admin)reader;
                                break;
                            default:
                                throw new Exception($"Seleccione un tipo de usuario correcto");
                                break;
                        }
                        if (usuario.User != user)
                        {
                            throw new Exception("El usuario ingresado no existe.");
                        }
                        if (!usuario.CheckPass(pass))
                        {
                            throw new Exception($"La contraseña ingresada es incorrecta.");
                        }
                        if (usuario.tipoUsuario != tipoUsuario)
                        {
                            throw new Exception($"El usuario ingresado no es {tipoUsuario}.");
                        }

                        retorno = usuario;
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
            } else
            {
                throw new Exception("Rellene los campos requeridos");
            }
            return retorno;
        }
    }
}
