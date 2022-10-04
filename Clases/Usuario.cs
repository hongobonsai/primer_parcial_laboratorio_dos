using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.enums;

namespace Clases
{
    /// <summary>
    /// Clase base de los demas usuarios del sistema. Almacena datos de LOGIN.
    /// </summary>
    public class Usuario
    {
        private string? _user;
        private string? _pass;
        private eType _type;

        public Usuario(string? user, string? pass, eType type)
        {
            _user = user;
            _pass = pass;
            _type = type;
        }
        public bool CheckPass(string pass)
        {
            bool retorno = false;
            if (_pass == pass)
            {
                retorno = true;
            }
            return retorno;
        }
        public string? User
        {
            get { return _user; }
            set { _user = value; }
        }
        public string? Pass
        {
            set { _pass = value; }
        }
        public eType tipoUsuario
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
