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
    public partial class AltaExamen : Form
    {
        Profesor _profesor;
        Dictionary<string, Materia> _materiasDict;
        public AltaExamen(Profesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            _materiasDict = SysControl.GetMateriasProfesor(_profesor.Dni);
        }

        private void AltaExamen_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            Dictionary<string, Materia?> materiasDict = new();
            materiasDict = SysControl.GetMateriasProfesor(_profesor.Dni);
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
                sb.AppendLine($"");
            }
            MessageBox.Show($"{sb}");
            datagrid.Show();
        }

        private void btnCrearExamen_Click(object sender, EventArgs e)
        {
            Examen? examenBuff;
            try
            {
                examenBuff = _profesor.NewExamen(txtNombre.Text, cmbMateria.Text.ToString(), dtpFecha.Value);
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
