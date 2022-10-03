using Accessibility;
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
    public partial class GestionProfesor : Form
    {
        private Login _loginMenu;
        private Profesor? _profesorLogueado;
        public GestionProfesor(Login loginMenu, Profesor? profesor)
        {
            InitializeComponent();
            _loginMenu = loginMenu;
            _profesorLogueado = profesor;
        }
        private void GestionProfesor_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Bienvenido, " + _profesorLogueado.Nombre + " " + _profesorLogueado.Apellido;
        }
        private void GestionProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginMenu.Show();
        }

        private void btnCrearExamen_Click(object sender, EventArgs e)
        {
            AltaExamen altaExamenMenu = new (_profesorLogueado);
            altaExamenMenu.Show();
        }

        private void btnEvaluarAlumno_Click(object sender, EventArgs e)
        {
            EvaluarAlumno evaluarAlumnoMenu = new(_profesorLogueado);
            evaluarAlumnoMenu.Show();
        }

        private void btnVerMaterias_Click(object sender, EventArgs e)
        {
            try
            {
                SysControl.GetMateriasProfesor(_profesorLogueado.Dni);
                DataGridProfesor verMateriasProfeMenu = new(_profesorLogueado);
                verMateriasProfeMenu.Show();
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
