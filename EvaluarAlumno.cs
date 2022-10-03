using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class EvaluarAlumno : Form
    {
        private Profesor? _profesorLogueado;
        Dictionary<string, Materia> _materiasDict;
        public EvaluarAlumno(Profesor? profesorLogueado)
        {
            InitializeComponent();
            _profesorLogueado = profesorLogueado;
        }

        private void EvaluarAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                _materiasDict = SysControl.GetMateriasProfesor(_profesorLogueado.Dni);
                cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            DataGrid datagridAlumno = new("materia");
            datagridAlumno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid datagridMateria = new("alumno");
            datagridMateria.Show();
        }

        private void BtnAsignarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                if (Profesor.FinalizarCuatrimestre(int.Parse(txtDni.Text), cmbMateria.Text, (int)nudPrimero.Value, (int)nudSegundo.Value))
                {
                    MessageBox.Show("El alumno finalizó la materia APROBADO");
                }
                else
                {
                    MessageBox.Show("El alumno finalizó la materia DESAPROBADO");
                }
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
    }
}
