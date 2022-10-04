using alonso_nicolas_primer_parcial_labo.Clases.enums;
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
    public partial class PresentarAsistencia : Form
    {
        private Dictionary<string?, Materia> _materiasDict;
        private Alumno? _alumnoLogueado;
        public PresentarAsistencia(Alumno? alumno)
        {
            InitializeComponent();
            _materiasDict = SysControl.GetMaterias();
            _alumnoLogueado = alumno;
        }

        private void PresentarAsistencia_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            cmbAsistencia.DataSource = Enum.GetValues(typeof(eAsistencia));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _alumnoLogueado.PresentarAsistencia(cmbMateria.Text, (eAsistencia)cmbAsistencia.SelectedValue);
                MessageBox.Show($"Se presentó asistencia a la materia {cmbMateria.Text}.");
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message == "El alumno no se encuentra cursando esta materia.")
                {
                    MessageBox.Show($"{ex.Message}");
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = ex.Message;
                }
            }
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("materia");
            datagrid.Show();
        }
    }
}
