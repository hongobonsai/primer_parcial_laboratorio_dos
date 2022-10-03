using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.enums;

namespace Clases
{
    public class Nacimiento
    {
        private int _dia;
        private eMes _mes;
        private int _anio;
        public Nacimiento(int dia, eMes mes, int anio)
        {
            _dia = dia;
            _mes = mes;
            _anio = anio;
        }
        public int Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        public eMes Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }
        public int Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
    }
}
