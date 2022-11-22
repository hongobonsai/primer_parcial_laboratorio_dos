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
    public partial class DataGridAlumno : Form
    {
        private List<MateriaCursada> _materiasList = new();
        private Alumno _alumnoLogueado;
        BindingSource bindingSource = new();
        public DataGridAlumno(Alumno alumno)
        {
            InitializeComponent();
            _alumnoLogueado = alumno;
        }

        private void DataGridAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                _materiasList = SysControl.GetMateriasAlumnoList(_alumnoLogueado.User);
                bindingSource.DataSource = _materiasList;
                dgvMateriasAlumno.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
