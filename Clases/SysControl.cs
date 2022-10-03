using Clases;
using Clases.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class SysControl
    {
        static Dictionary<string, Usuario?> _usuariosDict;
        static Dictionary<string, Materia?> _materiasDict;

        static SysControl()
        {
            _usuariosDict = new Dictionary<string, Usuario?>();
            _materiasDict = new Dictionary<string, Materia?>();
            HardcodearUsuario();
        }
        public static void HardcodearUsuario()
        {
            DateTime nacimiento = new(2000, 8, 24);
            DateTime nacimientoDos = new(1987, 12, 29);
            _usuariosDict.Add("hongobonsai", new Admin("hongobonsai", "soyeladmin", eType.Admin));
            _usuariosDict.Add("pferrete", new Profesor("pferrete", "quelindaslasmatematicas", eType.Profesor, "Pablo", "Ferrete", 29203223, nacimiento, eGenero.Masculino));
            _usuariosDict.Add("fcardon", new Alumno("fcardon", "meahorrolacuota", eType.Alumno, "Franco", "Cardon", 1234, nacimientoDos, eGenero.Otro));
            _materiasDict.Add("matematica", new Materia("matematica", eCuatrimestre.Primero));
        }
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
        public static bool ExistUsuario(string user)
        {
            bool retorno = false;
            if (_usuariosDict.ContainsKey(user) == true)
            {
                retorno = true;
            }
            return retorno;
        }
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
        public static eType GetTipoUsuario(string? type)
        {
            eType retorno = eType.Alumno;
            if (type == "Profesor")
            {
                retorno = eType.Profesor;
            }
            return retorno;
        }
        public static Dictionary<string, Usuario?> GetUsuarios()
        {
            return _usuariosDict;
        }
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
        public static Dictionary<string, Materia?> GetMaterias()
        {
            return _materiasDict;
        }
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
        public static bool ExistMateria(string nombre)
        {
            bool retorno = false;
            if (_materiasDict.ContainsKey(nombre) == true)
            {
                retorno = true;
            }
            return retorno;
        }
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