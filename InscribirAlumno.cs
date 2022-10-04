using Clases;
using Clases.enums;
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
    public partial class InscribirAlumno : Form
    {
        Dictionary<string, Materia?> _materiasDict;
        private Alumno _alumno;
        public InscribirAlumno(Alumno alumno)
        {
            InitializeComponent();
            _alumno = alumno;
        }
        private void InscribirAlumno_Load(object sender, EventArgs e)
        {
            _materiasDict = SysControl.GetMaterias();
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            if (_alumno.Genero != eGenero.Femenino)
            {
                lblTitle.Text = $"Inscripcion del alumno {_alumno.Nombre} {_alumno.Apellido}";
            } else
            {
                lblTitle.Text = $"Inscripcion de la alumna {_alumno.Nombre} {_alumno.Apellido}";
            }
        }
        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("materia");
            datagrid.Show();
        }

        private void BtnInscribirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno.InscribirseMateria(cmbMateria.Text, _alumno);
                MessageBox.Show($"El usuario {_alumno.User} se agrego a la materia {cmbMateria.Text}.");
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message == "El alumno no aprobó la correlativa correspondiente.")
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
    }
}
