using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Clases.enums;

namespace Clases
{
    /// <summary>
    /// Esta clase representa la clase padre de profesor y de alumno. Almacena los datos correspondientes a la persona.
    /// Hereda de Usuario
    /// </summary>
    public abstract class Academico : Usuario
    {
        private string? _nombre;
        private string? _apellido;
        private int _dni;
        private DateTime? _nacimiento;
        private eGenero _genero;
        public Academico(string? user, string? pass, eType type, string? nombre, string? apellido, int dni, DateTime nacimiento, eGenero genero) : base(user, pass, type)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _nacimiento = nacimiento;
            _genero = genero;
        }
        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string? Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public DateTime? Nacimiento
        {
            get { return _nacimiento; }
            set { _nacimiento = value; }
        }
        public eGenero Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        /// <summary>
        /// Valida los datos del academico, los cuales recibe por parametro. Verifica que los campos no se encuentren vacíos, y que los datos
        /// correspondan a los esperados.
        /// </summary>
        /// <returns>
        /// True = OK, False = NO VALIDO CORRECTAMENTE
        /// </returns>
        public static bool ValidarDatosAcademico(string? user, string? pass, eType type, string? nombre, string? apellido, string dniStr, DateTime nacimiento, eGenero genero)
        {
            bool retorno = false;
            int dni;
            if(user != "" && pass != "" && nombre != "" && apellido != "" && dniStr != "" && nacimiento.Year > 1922)
            {
                if (int.TryParse(dniStr, out dni))
                {
                    if (dni > 0 && dni <= 99999999)
                    {
                        if (type == eType.Profesor || type == eType.Alumno && (genero == eGenero.Masculino || genero == eGenero.Femenino || genero == eGenero.Otro))
                        {
                            if (Funcionalidades.IsOnlyLetters(nombre) && Funcionalidades.IsOnlyLetters(apellido))
                            {
                                retorno = true;
                            }
                            else
                            {
                                throw new Exception("El nombre y el apellido solo pueden contener letras.");
                            }
                        }
                        else
                        {
                            throw new Exception("Verifique los selectores de tipo y género.");
                        }
                    }
                    else
                    {
                        throw new Exception("El Dni ingresado debe estar entre 0 y 100000000");
                    }
                }
                else
                {
                    throw new Exception($"El dni ingresado no está en un formato válido.");
                }
            }
            else
            {
                throw new Exception("Por favor verifique los datos ingresados.");
            }
            return retorno;
        }
    }
}
