using alonso_nicolas_primer_parcial_labo.Clases.enums;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class CambiarRegularidad : Form
    {
        private Alumno? _alumnoModificar;
        Dictionary<string, Materia?> _materiasDict;
        private MateriaCursada? _materia;
        public CambiarRegularidad()
        {
            InitializeComponent();
        }

        private void CambiarRegularidad_Load(object sender, EventArgs e)
        {
            _materiasDict = SysControl.GetMaterias();
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            cmbRegularidad.DataSource = Enum.GetValues(typeof(eRegularidad));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    _alumnoModificar = SysControl.GetAlumnoByDni(int.Parse(txtDni.Text));
                    _materia = _alumnoModificar.GetMateriaEnCurso(cmbMateria.Text);
                    Admin.CambiarRegularidad(_alumnoModificar, _materia, (eRegularidad)cmbRegularidad.SelectedValue);
                    MessageBox.Show($"Se cambió la regularidad de {_alumnoModificar.Nombre} {_alumnoModificar.Apellido}\nen la materia {(string)_materia}.");
                    this.Close();
                } else
                {
                    throw new Exception("Completar el dni.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("materia");
            datagrid.Show();
        }
    }
}
