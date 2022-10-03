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
            StringBuilder sb = new();
            Dictionary<string, Usuario?> usuariosDict = new();
            Dictionary<string, Academico?> academicosDict = new();
            usuariosDict = SysControl.GetAdmins();
            usuariosDict.AppendDict(SysControl.GetProfesores());
            usuariosDict.AppendDict(SysControl.GetAlumnos());
            foreach (KeyValuePair<string, Usuario> usuario in usuariosDict)
            {
                if(usuario.Value.tipoUsuario == eType.Admin)
                {
                    sb.AppendLine($"Usuario: {usuario.Value.User}");
                    sb.AppendLine($"Tipo de usuario: {usuario.Value.tipoUsuario.ToString()}");
                    sb.AppendLine("----------------------------");
                }
                else
                {
                    academicosDict.Add(usuario.Value.User, (Academico)usuario.Value);
                }
            }
            foreach (KeyValuePair<string, Academico> academico in academicosDict)
            {
                sb.AppendLine($"Usuario: {academico.Value.User}");
                sb.AppendLine($"Tipo de usuario: {academico.Value.tipoUsuario.ToString()}");
                sb.AppendLine($"Nombre: {academico.Value.Nombre}");
                sb.AppendLine($"Apellido: {academico.Value.Apellido}");
                sb.AppendLine($"Genero: {academico.Value.Genero}");
                sb.AppendLine($"Dni: {academico.Value.Dni}");
                sb.AppendLine($"Fecha de nacimiento: {academico.Value.Nacimiento}");
                sb.AppendLine("----------------------------");
            }
            MessageBox.Show(sb.ToString());
            DataGrid datagrid = new("usuario");
            datagrid.Show();
        }

        private void BtnAsignarProfesor_Click(object sender, EventArgs e)
        {
            InscribirProfesor inscribirProfesor = new ();
            inscribirProfesor.Show();
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarRegularidad regularidadMenu = new();
            regularidadMenu.Show();
        }
    }
}
//StringBuilder sb = new();
//Dictionary<string, Usuario?> usuariosDict = new();
//usuariosDict = SysControl.GetUsuarios();
//foreach (KeyValuePair<string, Usuario> usuario in usuariosDict)
//{
//    if (usuario.Value.tipoUsuario == eType.Admin)
//    {
//        sb.AppendLine($"Usuario: {usuario.Value.User}");
//        sb.AppendLine("Tipo de usuario: Admin");
//    }
//    else
//    {
//        sb.AppendLine($"Usuario: {usuario.Value.User}");
//        sb.AppendLine($"Tipo de usuario: {}");
//        sb.AppendLine($"Nombre: {usuario.Value.}");
//        sb.AppendLine($"Apellido: {}");
//        sb.AppendLine($"Genero: {}");
//        sb.AppendLine($"Dni: {}");
//        sb.AppendLine($"Fecha de nacimiento: {}");
//        sb.AppendLine($"Nombre: {}");
//    }