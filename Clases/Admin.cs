using alonso_nicolas_primer_parcial_labo.Clases.enums;
using Clases.enums;

namespace Clases
{
    public sealed class Admin : Usuario
    {
        /// <summary>
        /// Esta clase representa a un administrador del sistema.
        /// Hereda de Usuario
        /// </summary>
        public Admin(string? user, string? pass, eType type) : base(user, pass, type)
        {
            //TODO HACER QUE SOLO SE PUEDA VERIFICAR QUE APRUEBE SI ESTA PRESENTE Y ETC QUE DIJO RAMPI XD
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
        public static void CambiarRegularidad(Alumno? alumno, MateriaCursada materia, eRegularidad regularidad)
        {
            bool cursaMateria = false;
            if (alumno != null && materia != null)
            {
                if(alumno.MateriasCursadas != null)
                {
                    foreach (MateriaCursada matCur in alumno.MateriasCursadas)
                    {
                        if((string)matCur == (string)materia)
                        {
                            cursaMateria = true;
                            matCur.Regularidad = regularidad;
                            break;
                        }
                    }
                    if (cursaMateria == false)
                    {
                        throw new Exception("El alumno no cursa la materia seleccionada.");
                    }
                }
                else
                {
                    throw new Exception("El alumno no cursa ninguna materia actualmente.");
                }
            }
            else
            {
                throw new Exception("Por favor, verificar los datos.");
            }
        }

    }
}