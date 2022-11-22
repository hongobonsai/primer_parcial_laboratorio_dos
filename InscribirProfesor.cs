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
    public partial class InscribirProfesor : Form
    {
        Dictionary<string, Usuario?> _profesoresDict;
        Dictionary<string, Materia?> _materiasDict;
        public InscribirProfesor()
        {
            InitializeComponent();
        }
        private void InscribirProfesor_Load(object sender, EventArgs e)
        {
            _profesoresDict = SysControl.GetProfesores();
            _materiasDict = SysControl.GetMaterias();
            cmbAgregarProfesor.DataSource = _profesoresDict.ToList(); cmbAgregarProfesor.DisplayMember = "Key";
            cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
        }
        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("materia");
            datagrid.Show();
        }

        private void cmbAgregarCorrelativa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAsignarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                Materia? materiaBuff = SysControl.GetMateria(cmbMateria.Text);
                SysControl.AsignarProfesor(materiaBuff, cmbAgregarProfesor.Text);
                //Profesor? profesorBuff = SysControl.AsignarProfesor(materiaBuff, cmbAgregarProfesor.Text);
                //profesorBuff.MateriasAsignadas.Add(materiaBuff.Nombre);
                MessageBox.Show($"El profesor {cmbAgregarProfesor.Text} se agrego a la materia {materiaBuff.Nombre}.");
                this.Close();
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            DataGrid datagrid = new("profesor");
            datagrid.Show();
        }
    }
}
