using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class DataGridListaAlumnos : Form
    {
        string _materia;
        string _profesor;
        List<Alumno> _listaAlumnos;
        BindingSource bindingSource = new();
        public DataGridListaAlumnos(string materia, string profesor)
        {
            InitializeComponent();
            _materia = materia;
            _profesor = profesor;
        }

        private void DataGridListaAlumnos_Load(object sender, EventArgs e)
        {
            _listaAlumnos = Profesor.GetAlumnosMateriaProfesor(_materia, _profesor);
            bindingSource.DataSource = _listaAlumnos;
            dgvAlumnos.DataSource = bindingSource;
            lblTitle.Text = "Alumnos actuales de " + $"{_materia}:";;
        }
    }
}
