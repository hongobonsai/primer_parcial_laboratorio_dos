using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public Usuario()
        {

        }
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
        public string GetPass()
        {
            return this._pass;
        }
        public static explicit operator Usuario(SqlDataReader v)
        {
            Usuario p = new Usuario(v["usuario"].ToString() ?? "", v["contrasenia"].ToString() ?? "", (eType)v["tipoUsuario"]);

            return p;
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
