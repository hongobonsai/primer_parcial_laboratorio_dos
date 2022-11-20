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
    public partial class SeleccionarAlumno : Form
    {
        Alumno _alumnoAInscribir;
        public SeleccionarAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid datagridMateria = new("alumno");
            datagridMateria.Show();
        }

        private void BtnAsignarProfesor_Click(object sender, EventArgs e)
        {
            int buffDni;
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    if(int.TryParse(txtDni.Text, out buffDni))
                    {
                        try
                        {
                            _alumnoAInscribir = SysControl.GetAlumnoByDni(int.Parse(txtDni.Text));
                            InscribirAlumno inscribirAlumnoMenu = new(_alumnoAInscribir);
                            inscribirAlumnoMenu.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        throw new Exception("El dni ingresado debe contener solo numeros.");
                    }
                }
                else
                {
                    throw new Exception("Completar el dni.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeleccionarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
