using Clases;
using Clases.enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class AltaUsuario : Form
    {
        private Admin? _adminLogueado;
        GestionAdmin adminMenu;
        private bool _esAltaDeAdmin;
        public AltaUsuario(Admin? admin, GestionAdmin admMenu, bool esAltaDeAdmin)
        {
            InitializeComponent();
            adminMenu = admMenu;
            cmbGenero.DataSource = Enum.GetValues(typeof(eGenero));
            //TODO solucionar el asunto de los tipo de usuario, el enum que no anda (llega null)
            _adminLogueado = admin;
            _esAltaDeAdmin = esAltaDeAdmin;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            if (_esAltaDeAdmin == true)
            {
                txtNombre.Visible = false;
                txtApellido.Visible = false;
                picUtnFra.Visible = true;
                lblTitle.Text = "Ingrese los datos del nuevo ADMIN";
                btnAceptarAdmin.Visible = true;
                btnAceptarAcademico.Visible = false;
                //agregar DateTime Select
                //DateTime fecha = dateTimePicker1.Value;
                //MessageBox.Show($"{fecha.ToString("dd/mm/yyyy")}");
            }
        }

        private void btnAceptarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.NewAdmin(txtUser.Text, txtPass.Text);
                MessageBox.Show($"El admin {txtUser.Text} se creó correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                lblLogError.Text = ex.Message;
                lblLogError.Visible = true;
            }
        }
        private void btnAceptarAcademico_Click(object sender, EventArgs e)
        {
            //               string tipo = ex.GetType().Name.ToString();
            //TODO ver de capturar la excepcion rara
            try
            {
                Admin.NewAcademico(txtUser.Text, txtPass.Text, SysControl.GetTipoUsuario((string)cmbType.SelectedItem), txtNombre.Text, txtApellido.Text, txtDni.Text, dtpNacimiento.Value, (eGenero)cmbGenero.SelectedValue);
            MessageBox.Show($"El {(string)cmbType.SelectedItem} {txtUser.Text} se creó correctamente.");
            this.Close();
            }
            catch (Exception ex)
            {
                lblLogError.Text = ex.Message;
                lblLogError.Visible = true;
            }
        }

        private void chbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVer.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void AltaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminMenu.Show();
        }
    }
}
