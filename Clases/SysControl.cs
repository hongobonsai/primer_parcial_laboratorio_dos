using Clases;
using Clases.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Clase estatica que actúa de "base de datos" del sistema. Almacena todos los datos y sus metodos permiten interactuar con los mismos.
    /// </summary>
    public static class SysControl
    {
        static Dictionary<string, Usuario?> _usuariosDict;
        static Dictionary<string, Materia?> _materiasDict;

        static SysControl()
        {
            _usuariosDict = new Dictionary<string, Usuario?>();
            _materiasDict = new Dictionary<string, Materia?>();
            HardcodearDatos();
        }
        /// <summary>
        /// Harcodea los datos pedidos por la consigna (admin, alumnos, profesores, materias) para que el programa funcione sin necesidad de cargar usuarios ni materias.
        /// </summary>
        public static void HardcodearDatos()
        {
            Materia materiaBuff;
            DateTime nacimiento = new(2000, 8, 24);
            DateTime nacimientoDos = new(1987, 12, 29);
            DateTime nacimientoTres = new(1970, 6, 17);
            DateTime nacimientoCuatro = new(1950, 1, 3);
            DateTime nacimientoCinco = new(2006, 5, 10);
            _usuariosDict.Add("hongobonsai", new Admin("hongobonsai", "soyeladmin", eType.Admin));
            _usuariosDict.Add("pferrete", new Profesor("pferrete", "quelindaslasmatematicas", eType.Profesor, "Pablo", "Ferrete", 29203223, nacimiento, eGenero.Masculino));
            _usuariosDict.Add("adeyua", new Profesor("adeyua", "adeyua", eType.Profesor, "Andrea", "Deyuanine", 18923601, nacimientoCuatro, eGenero.Femenino));
            _usuariosDict.Add("fcardon", new Alumno("fcardon", "meahorrolacuota", eType.Alumno, "Franco", "Cardon", 43982312, nacimientoDos, eGenero.Otro));
            _usuariosDict.Add("jorgeluis", new Alumno("jorgeluis", "jorgeluis", eType.Alumno, "Jorge", "Luis", 39842100, nacimientoTres, eGenero.Masculino));
            _usuariosDict.Add("ayeazu", new Alumno("ayeazu", "jorgeluis", eType.Alumno, "Ayelen", "Azul", 60923812, nacimientoCinco, eGenero.Femenino));
            _materiasDict.Add("matematica", new Materia("matematica", eCuatrimestre.Primero));
            _materiasDict.Add("spd", new Materia("spd", eCuatrimestre.Primero));
            _materiasDict.Add("arquitectura so", new Materia("arquitectura so", eCuatrimestre.Segundo));
            _materiasDict.TryGetValue("arquitectura so", out materiaBuff);
            AsignarCorrelativa(materiaBuff, "spd");
        }
        /// <summary>
        /// Valida los datos de login de usuario recibidos por parametro. Tambien devuelve el Usuario que corresponde al user recibido.
        /// </summary>
        public static Usuario? LoginCheck(string user, string pass, eType tipoUsuario)
        {
            Usuario? retorno = null;
            Usuario? buffUser;
            if(user != "" && pass != "")
            {
                if (_usuariosDict.TryGetValue(user, out buffUser))
                {
                    if (buffUser.CheckPass(pass))
                    {
                        if (buffUser.tipoUsuario == tipoUsuario)
                        {
                            retorno = buffUser;
                        }
                        else
                        {
                            throw new Exception($"El usuario ingresado no es {tipoUsuario}.");
                        }
                    }
                    else
                    {
                        throw new Exception($"La contraseña ingresada es incorrecta.");
                    }
                }
                else
                {
                    throw new Exception("El usuario ingresado no existe.");
                }
            } else
            {
                throw new Exception("Por favor, complete los campos requeridos.");
            }
            return retorno;
        }
        /// <summary>
        /// Verifica si el user recibido corresponde al nombre de usuario de algun Usuario.
        /// </summary>
        public static bool ExistUsuario(string user)
        {
            bool retorno = false;
            if (_usuariosDict.ContainsKey(user) == true)
            {
                retorno = true;
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
            List<Alumno> alumnos = GetAlumnosList();
            List<Profesor> profesores = GetProfesoresList();
            foreach (Alumno alumno in alumnos)
            {
                if(alumno.Dni == dni)
                {
                    retorno = true;
                    break;
                }
            }
            foreach (Profesor profesor in profesores)
            {
                if (profesor.Dni == dni)
                {
                    retorno = true;
                    break;
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
                _usuariosDict.Add(usuario.User, usuario);
                retorno = true;
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
            return _usuariosDict;
        }
        /// <summary>
        /// Obtiene cada usuario del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de usuarios del sistema
        /// </summary>
        public static List<Usuario> GetUsuariosList()
        {
            List<Usuario> usuariosList = new();
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value is Usuario usuario)
                {
                    usuariosList.Add(usuario);
                }
            }
            return usuariosList;
        }
        /// <summary>
        /// Devuelve un diccionario de admin del sistema
        /// </summary>
        public static Dictionary<string, Usuario?> GetAdmins()
        {
            Dictionary<string, Usuario?> admins = new();
            foreach (KeyValuePair<string, Usuario> usuario in _usuariosDict)
            {
                if (usuario.Value.tipoUsuario == eType.Admin)
                {
                    admins.Add(usuario.Value.User, (Admin)usuario.Value);
                }
            }
            return admins;
        }
        /// <summary>
        /// Obtiene cada admin del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de admins del sistema
        /// </summary>
        public static List<Admin> GetAdminsList()
        {
            List<Admin> adminsList = new();
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value is Admin admin)
                {
                    adminsList.Add(admin);
                }
            }
            return adminsList;
        }
        /// <summary>
        /// Devuelve un diccionario de profesores del sistema
        /// </summary>
        public static Dictionary<string, Usuario?> GetProfesores()
        {
            Dictionary<string, Usuario?> profesores = new ();
            foreach (KeyValuePair<string, Usuario> usuario in _usuariosDict)
            {
                if(usuario.Value.tipoUsuario == eType.Profesor)
                {
                    profesores.Add(usuario.Value.User, (Profesor)usuario.Value);
                }
            }
            return profesores;
        }
        /// <summary>
        /// Obtiene cada profesor del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de profesores del sistema
        /// </summary>
        public static List<Profesor> GetProfesoresList()
        {
            List<Profesor> profesoresList = new ();
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value is Profesor profesor)
                {
                    profesoresList.Add(profesor);
                }
            }
            return profesoresList;
        }
        /// <summary>
        /// Obtiene el profesor correspondiente al usuario recibido por parametro.
        /// </summary>
        /// <returns>
        /// El profesor obtenido.
        /// </returns>
        public static Profesor? GetProfesor(string usuarioProfesor)
        {
            Profesor? profesorBuff = null;
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value.User == usuarioProfesor)
                {
                    profesorBuff = (Profesor)item.Value;
                }
            }
            if(profesorBuff == null)
            {
                 throw (new Exception("El profesor ingresado no existe."));
            }
            return profesorBuff;
        }
        /// <summary>
        /// Obtiene el profesor correspondiente al dni recibido. Luego, obtiene las materias correspondientes al profesor.
        /// </summary>
        /// <returns>
        /// El diccionario con todas las materias obtenidas
        /// </returns>
        public static Dictionary<string, Materia> GetMateriasProfesor(int dni)
        {
            Dictionary<string, Materia> materiasProfesor = new ();
            foreach (KeyValuePair<string, Materia> materia in _materiasDict)
            {
                foreach (Profesor profesor in materia.Value.Profesores)
                {
                    if (profesor.Dni == dni)
                    {
                        materiasProfesor.Add(materia.Value.Nombre, materia.Value);
                    }
                }
            }
            if (materiasProfesor.Count == 0)
            {
                throw new Exception("El profesor no está asignado a ninguna materia.");
            }
            return materiasProfesor;
        }
        /// <summary>
        /// Llama a GetMateriasProfesor, y convierte ese diccionario de materias del profesor en una lista.
        /// </summary>
        /// <returns>
        /// La lista con todas las materias obtenidas
        /// </returns>
        public static List<Materia> GetMateriasProfesorList(int dni)
        {
            try
            {
                Dictionary<string, Materia> materiasProfesorDict = GetMateriasProfesor(dni);
                List<Materia> materiasProfesorList = new();
                foreach (KeyValuePair<string, Materia> item in materiasProfesorDict)
                {
                    if (item.Value is Materia materia)
                    {
                        materiasProfesorList.Add(materia);
                    }
                }
                return materiasProfesorList;
            }
            catch (Exception ex)
            {
                throw (new Exception($"{ex.Message}"));
            }
        }
        /// <summary>
        /// Devuelve un diccionario de alumnos del sistema
        /// </summary>
        public static Dictionary<string, Usuario?> GetAlumnos()
        {
            Dictionary<string, Usuario?> alumnos = new();
            foreach (KeyValuePair<string, Usuario> usuario in _usuariosDict)
            {
                if (usuario.Value.tipoUsuario == eType.Alumno)
                {
                    alumnos.Add(usuario.Value.User, (Alumno)usuario.Value);
                }
            }
            return alumnos;
        }
        /// <summary>
        /// Obtiene cada alumno del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de alumnos del sistema
        /// </summary>
        public static List<Alumno> GetAlumnosList()
        {
            List<Alumno> alumnosList = new();
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value is Alumno alumno)
                {
                    alumnosList.Add(alumno);
                }
            }
            return alumnosList;
        }
        /// <summary>
        /// Obtiene el alumno correspondiente al usuario recibido por parametro.
        /// </summary>
        /// <returns>
        /// El alumno obtenido.
        /// </returns>
        public static Alumno? GetAlumno(string usuarioAlumno)
        {
            Alumno? alumnoBuff = null;
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if (item.Value.User == usuarioAlumno)
                {
                    alumnoBuff = (Alumno)item.Value;
                }
            }
            if (alumnoBuff == null)
            {
                throw (new Exception("El profesor ingresado no existe."));
            }
            return alumnoBuff;
        }
        /// <summary>
        /// Obtiene el alumno correspondiente al dni recibido por parametro.
        /// </summary>
        /// <returns>
        /// El alumno obtenido.
        /// </returns>
        public static Alumno? GetAlumnoByDni(int dni)
        {
            Alumno? alumnoBuff = null;
            foreach (KeyValuePair<string, Usuario> item in _usuariosDict)
            {
                if(item.Value.tipoUsuario == eType.Alumno)
                {
                    alumnoBuff = (Alumno)item.Value;
                    if (alumnoBuff.Dni == dni)
                    {
                        alumnoBuff = (Alumno)item.Value;
                        break;
                    }
                }
            }
            if (alumnoBuff == null)
            {
                throw (new Exception("El dni ingresado no corresponde a un alumno."));
            }
            return alumnoBuff;
        }
        /// <summary>
        /// Devuelve un diccionario con todas las materias del sistema.
        /// </summary>
        public static Dictionary<string, Materia?> GetMaterias()
        {
            return _materiasDict;
        }
        /// <summary>
        /// Obtiene cada materia del diccionario, los agrega a un buffer de tipo List, y devuelve una lista de materias del sistema
        /// </summary>
        public static List<Materia> GetMateriasList()
        {
            List<Materia> materiasList = new();
            foreach (KeyValuePair<string, Materia> item in _materiasDict)
            {
                if (item.Value is Materia materia)
                {
                    materiasList.Add(materia);
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
            foreach (KeyValuePair<string, Materia> item in _materiasDict)
            {
                if (item.Value.Nombre == nombreMateria)
                {
                    materiaBuff = item.Value;
                    break;
                }
            }
            if(materiaBuff == null)
            {
                throw (new Exception("La materia ingresada no existe."));
            }
            return materiaBuff;
        }
        /// <summary>
        /// Agrega el objeto materia recibido por parametro, al diccionario de materias del sistema.
        /// </summary>
        public static bool AgregarMateria(Materia materia)
        {
            bool retorno = false;
            if (materia != null)
            {
                _materiasDict.Add(materia.Nombre, materia);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Verifica si el string recibido por parametro corresponde a una materia existente
        /// </summary>
        /// <returns>
        /// True si existe, False si no existe.
        /// </returns>
        public static bool ExistMateria(string nombre)
        {
            bool retorno = false;
            if (_materiasDict.ContainsKey(nombre) == true)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Carga una materia correlativa existente en el campo _correlativa de la materia recibida por parametro.
        /// </summary>
        public static bool AsignarCorrelativa(Materia materia, string correlativa)
        {
            bool retorno = false;
            if(materia != null)
            {
                if (correlativa != "")
                {
                    if (_materiasDict.ContainsKey(correlativa) == true)
                    {
                        materia.Correlativa = correlativa;
                        retorno = true;
                    }
                    else
                    {
                        throw new Exception("La correlativa ingresada no existe");
                    }
                }
                else
                {
                    throw new Exception("Verificar el campo correlativa.");
                }
            }
            return retorno;
        }
        /// <summary>
        /// Asigna un profesor a una materia existente. Carga la materia en el campo _materiasAsignadas del profesor correspondiente. Carga el profesor en la lista de profesores de la materia.
        /// </summary>
        public static Profesor? AsignarProfesor(Materia materiaBuff, string userProfesor)
        {
            Profesor retorno = null;
            Usuario? usuario;
            Profesor? profesor;
            if (materiaBuff != null)
            {
                if (userProfesor != "")
                {
                    if (_usuariosDict.TryGetValue(userProfesor, out usuario) == true)
                    {
                        foreach(Profesor profe in materiaBuff.Profesores)
                        {
                            if(profe.User == userProfesor)
                            {
                                throw (new Exception("El profesor ingresado ya está asignado a la materia"));
                            }
                        }
                        profesor = (Profesor)usuario;
                        materiaBuff.Profesores.Add(profesor);
                        profesor.MateriasAsignadas.Add(materiaBuff.Nombre);
                        retorno = profesor;
                    }
                    else
                    {
                        throw new Exception("El usuario no coincide con ningún profesor.");
                    }
                }
                else
                {
                    throw new Exception("Verificar el campo profesor.");
                }
            }
            return retorno;
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