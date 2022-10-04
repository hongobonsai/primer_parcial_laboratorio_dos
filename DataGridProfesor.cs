using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class DataGridProfesor : Form
    {
        private Dictionary<string, Materia> _materiasDict = new();
        private List<Materia> _materiasList = new();
        private Profesor _profesorLogueado;
        BindingSource bindingSource = new();
        public DataGridProfesor(Profesor profesor)
        {
            InitializeComponent();
            _profesorLogueado = profesor;
        }

        private void DataGridProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                _materiasDict = SysControl.GetMateriasProfesor(_profesorLogueado.Dni);
                _materiasList = SysControl.GetMateriasProfesorList(_profesorLogueado.Dni);
                bindingSource.DataSource = _materiasList;
                dgvMateriasProfe.DataSource = bindingSource;
                cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerMaterias_Click(object sender, EventArgs e)
        {

            DataGridListaAlumnos listaAlumnosDvg = new(SysControl.GetMateria(cmbMateria.Text));
            listaAlumnosDvg.ShowDialog();
        }
    }
}
