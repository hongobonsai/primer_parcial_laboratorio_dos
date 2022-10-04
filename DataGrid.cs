using Clases;
using Clases.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class DataGrid : Form
    {
        string? _tipoVisualizado;
        public DataGrid(string? tipo)
        {
            _tipoVisualizado = tipo;
            InitializeComponent();
        }
        private void DataGrid_Load(object sender, EventArgs e)
        {
            btnAceptarAca.Visible = false;
            btnAceptarUsu.Visible = false;
            lblCargados.Text = "Usuarios cargados:";
            BindingSource bindingSource = new();
            switch (_tipoVisualizado)
            {
                case "admin":
                    Size = new (300, 300);
                    dgvUsuarios.Size = new(276, 175);
                    btnAceptarUsu.Visible = true;
                    lblCargados.Text = "Admins cargados:";
                    List<Admin> adminsList = SysControl.GetAdminsList();
                    bindingSource.DataSource = adminsList;
                    dgvUsuarios.DataSource = bindingSource;
                    break;
                case "profesor":
                    btnAceptarAca.Visible = true;
                    lblCargados.Text = "Profesores cargados:";
                    List<Profesor> profesoresList = SysControl.GetProfesoresList();
                    bindingSource.DataSource = profesoresList;
                    dgvUsuarios.DataSource = bindingSource;
                    break;
                case "alumno":
                    btnAceptarAca.Visible = true;
                    lblCargados.Text = "Alumnos cargados:";
                    List<Alumno> alumnosList = SysControl.GetAlumnosList();
                    bindingSource.DataSource = alumnosList;
                    dgvUsuarios.DataSource = bindingSource;
                    break;
                case "materia":
                    Size = new(370, 300);
                    dgvUsuarios.Size = new(345, 175);
                    btnAceptarMat.Visible = true;
                    lblCargados.Text = "Materias cargadas:";
                    List<Materia> materiasList = SysControl.GetMateriasList();
                    bindingSource.DataSource = materiasList;
                    dgvUsuarios.DataSource = bindingSource;
                    break;
                //case "otro":
                //    Size = new(370, 300);
                //    dgvUsuarios.Size = new(345, 175);
                //    btnAceptarMat.Visible = true;
                //    lblCargados.Text = "Materias cargadas:";
                //    List<Materia> materiasList = SysControl.GetMateriasList();
                //    bindingSource.DataSource = materiasList;
                //    dgvUsuarios.DataSource = bindingSource;
                //    break;
                default:
                    Size = new (300, 300);
                    dgvUsuarios.Size = new (276, 175);
                    btnAceptarUsu.Visible = true;
                    List<Usuario> usuariosList = SysControl.GetUsuariosList();
                    bindingSource.DataSource = usuariosList;
                    dgvUsuarios.DataSource = bindingSource;
                    break;
            }
        }

        private void btnAceptarAca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarMat_Click(object sender, EventArgs e)
        {
            btnAceptarAca_Click(sender, e);
        }

        private void btnAceptarUsu_Click(object sender, EventArgs e)
        {
            btnAceptarAca_Click(sender, e);
        }
    }
}
