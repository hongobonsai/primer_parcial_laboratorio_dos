using Clases;
using Clases.enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class AltaMateria : Form
    {
        private Admin? _adminLogueado;
        GestionAdmin adminMenu;
        private bool _esAltaDeAdmin;
        Dictionary<string, Usuario?> _usuariosDict;
        Dictionary<string, Usuario?> _profesoresDict;
        Dictionary<string, Materia?> _materiasDict;
        public AltaMateria(Admin? admin, GestionAdmin admMenu)
        {
            InitializeComponent();
            adminMenu = admMenu;
            _adminLogueado = admin;
        }

        private void AltaMateria_Load(object sender, EventArgs e)
        {
            _usuariosDict = SysControl.GetUsuarios();
            _profesoresDict = SysControl.GetProfesores();
            _materiasDict = SysControl.GetMaterias();
            cmbCuatrimestre.DataSource = Enum.GetValues(typeof(eCuatrimestre));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Materia? materiaBuff;
            try
            {
                materiaBuff = Profesor.NewMateria(txtNombre.Text, SysControl.GetCuatrimestre(cmbCuatrimestre.SelectedItem.ToString()));
                if (cmbAgregarCorrelativa.Enabled)
                {
                    SysControl.AsignarCorrelativa(materiaBuff, cmbAgregarCorrelativa.Text);
                }
                if (cmbAgregarProfesor.Enabled)
                {
                    Profesor? profesorBuff = SysControl.AsignarProfesor(materiaBuff, cmbAgregarProfesor.Text);
                    profesorBuff.MateriasAsignadas.Add(materiaBuff.Nombre);
                }
                MessageBox.Show($"La materia {txtNombre.Text} se creó correctamente.");
                this.Close();
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
        private void chbAgregarProfesor_CheckedChanged(object sender, EventArgs e)
        {
            cmbAgregarProfesor.Enabled = chbAgregarProfesor.Checked;
            if (chbAgregarProfesor.Checked)
            {
                cmbAgregarProfesor.DataSource = _profesoresDict.ToList(); cmbAgregarProfesor.DisplayMember = "Key";
            }
            btnMostrarProfesores.Enabled = chbAgregarProfesor.Checked;
        }

        private void chbAgregarCorrelativa_CheckedChanged(object sender, EventArgs e)
        {
            cmbAgregarCorrelativa.Enabled = chbAgregarCorrelativa.Checked;
            if (cmbAgregarCorrelativa.Enabled)
            {
                cmbAgregarCorrelativa.DataSource = _materiasDict.ToList(); cmbAgregarCorrelativa.DisplayMember = "Key";
            }
            btnMostrarMaterias.Enabled = chbAgregarCorrelativa.Checked;
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            Dictionary<string, Materia?> materiasDict = new();
            materiasDict = SysControl.GetMaterias();
            DataGrid datagrid = new("materia");
            foreach (KeyValuePair<string, Materia> materia in materiasDict)
            {

                sb.AppendLine($"Nombre: {materia.Value.Nombre}");
                sb.AppendLine($"Cuatri: {materia.Value.Cuatrimestre}");
                sb.AppendLine($"Correlativa: {materia.Value.Correlativa}");
                sb.AppendLine($"Profesores: ");
                foreach (Profesor profesor in materia.Value.Profesores)
                {
                    sb.AppendLine($"{profesor.Nombre}" + $" {profesor.Apellido}");
                }
                sb.AppendLine($"Alumnos: ");
                foreach (Alumno alumno in materia.Value.Alumnos)
                {
                    sb.AppendLine($"{alumno.Nombre}" + $" {alumno.Apellido}");
                }
                sb.AppendLine($"");
            }
            MessageBox.Show($"{sb}");
            datagrid.Show();
        }

        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("profesor");
            datagrid.Show();
        }

        private void AltaMateria_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cmbAgregarCorrelativa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpbUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
