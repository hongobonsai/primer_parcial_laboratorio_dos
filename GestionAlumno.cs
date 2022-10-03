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
    public partial class GestionAlumno : Form
    {
        private Login _loginMenu;
        private Alumno? _alumnoLogueado;
        public GestionAlumno(Login loginMenu, Alumno? alumno)
        {
            InitializeComponent();
            _loginMenu = loginMenu;
            _alumnoLogueado = alumno;
        }
        private void GestionAlumno_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Bienvenido, " + _alumnoLogueado.Nombre + " " + _alumnoLogueado.Apellido;
        }
        private void GestionAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginMenu.Show();
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            InscribirAlumno altaAlumnoMenu = new(_alumnoLogueado);
            altaAlumnoMenu.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            PresentarAsistencia asistenciaMenu = new(_alumnoLogueado);
            asistenciaMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
