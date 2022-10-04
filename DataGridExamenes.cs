using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class DataGridExamenes : Form
    {
        Materia _materia;
        List<Examen> _listaExamenes;
        Profesor _profesorLogueado;
        BindingSource bindingSource = new();
        public DataGridExamenes(Materia materia, Profesor profesor)
        {
            InitializeComponent();
            _materia = materia;
            _profesorLogueado = profesor;
        }

        private void DataGridExamenes_Load(object sender, EventArgs e)
        {
            _listaExamenes = _profesorLogueado.GetExamenesMateria(_materia.Nombre);
            bindingSource.DataSource = _listaExamenes;
            dgvExamenesProfesor.DataSource = bindingSource;
            lblCargados.Text = "Examenes de la materia: " + $"{_materia.Nombre}:"; ;
        }
    }
}
