using Clases;
using Clases.enums;
using System.Drawing.Text;
using System.Text;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class GestionAdmin : Form
    {
        private Login _loginMenu;
        private Admin? adminLogueado;
        public GestionAdmin(Login loginMenu, Admin? admin)
        {
            InitializeComponent();
            _loginMenu = loginMenu;
            adminLogueado = admin;
        }
        private void GestionAdmin_Load(object sender, EventArgs e)
        {
            LblTitle.Text = "Bienvenido, admin " + adminLogueado.User;
        }
        private void GestionAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginMenu.Show();
        }

        private void BtnAltaAdmin_Click(object sender, EventArgs e)
        {
            AltaUsuario altaMenu = new(adminLogueado, this, true);
            altaMenu.ShowDialog();
        }

        private void BtnAltaAcademico_Click(object sender, EventArgs e)
        {
            AltaUsuario altaMenu = new(adminLogueado, this, false);
            altaMenu.ShowDialog();
        }

        private void BtnCrearMateria_Click(object sender, EventArgs e)
        {
            AltaMateria altaMateriaMenu = new(adminLogueado, this);
            altaMateriaMenu.ShowDialog();
        }

        private void BtnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("usuario");
            datagrid.ShowDialog();
        }

        private void BtnAsignarProfesor_Click(object sender, EventArgs e)
        {
            InscribirProfesor inscribirProfesor = new ();
            inscribirProfesor.ShowDialog();
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarRegularidad regularidadMenu = new();
            regularidadMenu.ShowDialog();
        }
    }
}