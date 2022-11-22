using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class AltaExamen : Form
    {
        Profesor _profesor;
        Dictionary<string, Materia> _materiasDict;
        public AltaExamen(Profesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            _materiasDict = SysControl.GetMateriasProfesorDict(_profesor.User);
        }

        private void AltaExamen_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            Dictionary<string, Materia> materiasDict = new();
            materiasDict = SysControl.GetMateriasProfesorDict(_profesor.User);
            DataGrid datagrid = new("materia");
            datagrid.Show();
        }

        private void btnCrearExamen_Click(object sender, EventArgs e)
        {
            Examen? examenBuff;
            try
            {
                Profesor.AgregarExamen(txtNombre.Text, cmbMateria.Text.ToString(), dtpFecha.Value, _profesor.User);
                MessageBox.Show($"El examen {txtNombre.Text} se creó correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
    }
}
