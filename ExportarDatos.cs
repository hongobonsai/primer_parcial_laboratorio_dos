using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alonso_nicolas_primer_parcial_labo
{
    public partial class ExportarDatos : Form
    {
        private List<Alumno> _alumnosList = new();
        private Dictionary<string, Materia> _materiasDict = new();
        private List<Materia> _materiasList = new();
        BindingSource bindingSource = new();
        public ExportarDatos()
        {
            InitializeComponent();
        }

        private void ExportarDatos_Load(object sender, EventArgs e)
        {
            try
            {
                _materiasDict = SysControl.GetMaterias();
                _materiasList = SysControl.GetMateriasList();
                bindingSource.DataSource = _materiasList;
                dgvMateriasProfe.DataSource = bindingSource;
                cmbMateria.DataSource = _materiasDict.ToList(); cmbMateria.DisplayMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionalidades.ExportAlumnosDeMateriaJson(cmbMateria.Text, _alumnosList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error durante la serialización.\nCodigo de error: {ex.Message}");
            }
            finally
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionalidades.ExportAlumnosDeMateriaXml(cmbMateria.Text, _alumnosList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error durante la serialización.\nCodigo de error: {ex.Message}");
            }
            finally
            {

            }
        }

        private void btnVerMaterias_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionalidades.ExportAlumnosDeMateriaCsv(cmbMateria.Text, _alumnosList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error durante la serialización.\nCodigo de error: {ex.Message}");
            }
            finally
            {

            }
        }
    }
}
