using Clases.enums;

namespace Clases
{
    public class Admin : Usuario
    {
        public Admin(string? user, string? pass, eType type) : base(user, pass, type)
        {
            
        }
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
        //TODO validar datetime con el <= datetimepicker now
        public static void NewAcademico(string? user, string? pass, eType type, string? nombre, string? apellido, string? dniStr, DateTime nacimiento, eGenero genero)
        {
            int dni;
            if (SysControl.ExistUsuario(user) != true)
            {
                try
                {
                    Academico.ValidarDatosAcademico(user, pass, type, nombre, apellido, dniStr, nacimiento, genero);
                    if (type == eType.Alumno)
                    {
                        dni = int.Parse(dniStr);
                        Alumno alumno = new(user, pass, type, nombre, apellido, dni, nacimiento, genero);
                        SysControl.AgregarUsuario(alumno);
                    }
                    else if (type == eType.Profesor)
                    {
                        dni = int.Parse(dniStr);
                        Profesor profesor = new(user, pass, type, nombre, apellido, dni, nacimiento, genero);
                        SysControl.AgregarUsuario(profesor);
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
        public static void CambiarRegularidad(Alumno? alumno, MateriaCursada materia, eRegularidad regularidad)
        {
            bool cursaMateria = false;
            if (alumno != null && materia != null)
            {
                if(alumno.MateriasActuales != null)
                {
                    foreach (MateriaCursada matCur in alumno.MateriasActuales)
                    {
                        if(matCur.Nombre == materia.Nombre)
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