using Clases;
using Clases.enums;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cmbTipoUsuario.DataSource = Enum.GetValues(typeof(eType));
        }

        private void btnHcAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "hongobonsai";
            txtContrasenia.Text = "soyeladmin";
            cmbTipoUsuario.SelectedIndex = 0;
        }

        private void btnHcProfesor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "pferrete";
            txtContrasenia.Text = "quelindaslasmatematicas";
            cmbTipoUsuario.SelectedIndex = 1;
        }

        private void btnHcAlumno_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "fcardon";
            txtContrasenia.Text = "meahorrolacuota";
            cmbTipoUsuario.SelectedIndex = 2;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chbVer_CheckedChanged(object sender, EventArgs e)
        {
            if(chbVer.Checked == true)
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Usuario? usuarioLogueado;

            try
            {
                usuarioLogueado = SysControl.LoginCheck(txtUsuario.Text, txtContrasenia.Text, (eType)cmbTipoUsuario.SelectedValue);
                this.Hide();
                //Ver clase dialog result
                switch ((eType)cmbTipoUsuario.SelectedValue)
                {
                    case eType.Admin:
                        GestionAdmin menuAdmin = new(this, (Admin?)usuarioLogueado);
                        menuAdmin.ShowDialog();
                        break;
                    case eType.Profesor:
                        GestionProfesor menuProfesor = new(this, (Profesor?)usuarioLogueado);
                        menuProfesor.ShowDialog();
                        break;
                    case eType.Alumno:
                        GestionAlumno menuAlumno = new(this, (Alumno?)usuarioLogueado);
                        menuAlumno.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Unexpected Error", "?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
                lblLogError.Visible = false;
            }
            catch (Exception ex)
            {
                lblLogError.Text = ex.Message;
                lblLogError.Visible = true;
            }
        }
    }
}

//                    else
//{
//    MessageBox.Show("La contraseña no coincide con el usuario ingresado", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//}
//                }
//            }
//            if (existeUsuario == false)
//{
//    MessageBox.Show("El usuario no existe", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//}