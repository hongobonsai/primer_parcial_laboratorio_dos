namespace alonso_nicolas_primer_parcial_labo
{
    partial class AltaMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMateria));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.cmbCuatrimestre = new System.Windows.Forms.ComboBox();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.btnMostrarProfesores = new System.Windows.Forms.Button();
            this.cmbAgregarCorrelativa = new System.Windows.Forms.ComboBox();
            this.cmbAgregarProfesor = new System.Windows.Forms.ComboBox();
            this.chbAgregarCorrelativa = new System.Windows.Forms.CheckBox();
            this.chbAgregarProfesor = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.gpbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(41, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Ingrese los datos de la materia:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Location = new System.Drawing.Point(18, 28);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.BackColor = System.Drawing.Color.Transparent;
            this.lblCuatrimestre.Location = new System.Drawing.Point(18, 78);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(75, 15);
            this.lblCuatrimestre.TabIndex = 7;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbLog.Controls.Add(this.cmbCuatrimestre);
            this.gpbLog.Controls.Add(this.btnCrearMateria);
            this.gpbLog.Controls.Add(this.picUtn);
            this.gpbLog.Controls.Add(this.lbNombre);
            this.gpbLog.Controls.Add(this.txtNombre);
            this.gpbLog.Controls.Add(this.lblCuatrimestre);
            this.gpbLog.Location = new System.Drawing.Point(41, 85);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(269, 191);
            this.gpbLog.TabIndex = 8;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Datos de la materia";
            // 
            // cmbCuatrimestre
            // 
            this.cmbCuatrimestre.FormattingEnabled = true;
            this.cmbCuatrimestre.Location = new System.Drawing.Point(18, 96);
            this.cmbCuatrimestre.Name = "cmbCuatrimestre";
            this.cmbCuatrimestre.Size = new System.Drawing.Size(231, 23);
            this.cmbCuatrimestre.TabIndex = 14;
            this.cmbCuatrimestre.Text = "seleccionar cuatrimestre...";
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.BackColor = System.Drawing.SystemColors.Window;
            this.btnCrearMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearMateria.Location = new System.Drawing.Point(153, 141);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(96, 25);
            this.btnCrearMateria.TabIndex = 11;
            this.btnCrearMateria.Text = "Crear Materia";
            this.btnCrearMateria.UseVisualStyleBackColor = false;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(18, 122);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 10;
            this.picUtn.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "nombre...";
            this.txtNombre.Size = new System.Drawing.Size(231, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gpbUsuario.Controls.Add(this.btnMostrarMaterias);
            this.gpbUsuario.Controls.Add(this.btnMostrarProfesores);
            this.gpbUsuario.Controls.Add(this.cmbAgregarCorrelativa);
            this.gpbUsuario.Controls.Add(this.cmbAgregarProfesor);
            this.gpbUsuario.Controls.Add(this.chbAgregarCorrelativa);
            this.gpbUsuario.Controls.Add(this.chbAgregarProfesor);
            this.gpbUsuario.Location = new System.Drawing.Point(347, 40);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(269, 236);
            this.gpbUsuario.TabIndex = 9;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Text = "Datos extra";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.SystemColors.Window;
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.Enabled = false;
            this.btnMostrarMaterias.Location = new System.Drawing.Point(153, 196);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 13;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.BackColor = System.Drawing.SystemColors.Window;
            this.btnMostrarProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarProfesores.Enabled = false;
            this.btnMostrarProfesores.Location = new System.Drawing.Point(153, 120);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarProfesores.TabIndex = 12;
            this.btnMostrarProfesores.Text = "Ver Profesores";
            this.btnMostrarProfesores.UseVisualStyleBackColor = false;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // cmbAgregarCorrelativa
            // 
            this.cmbAgregarCorrelativa.Enabled = false;
            this.cmbAgregarCorrelativa.FormattingEnabled = true;
            this.cmbAgregarCorrelativa.Location = new System.Drawing.Point(18, 167);
            this.cmbAgregarCorrelativa.Name = "cmbAgregarCorrelativa";
            this.cmbAgregarCorrelativa.Size = new System.Drawing.Size(231, 23);
            this.cmbAgregarCorrelativa.TabIndex = 11;
            this.cmbAgregarCorrelativa.Text = "seleccionar materia...";
            this.cmbAgregarCorrelativa.SelectedIndexChanged += new System.EventHandler(this.cmbAgregarCorrelativa_SelectedIndexChanged);
            // 
            // cmbAgregarProfesor
            // 
            this.cmbAgregarProfesor.Enabled = false;
            this.cmbAgregarProfesor.FormattingEnabled = true;
            this.cmbAgregarProfesor.Location = new System.Drawing.Point(18, 91);
            this.cmbAgregarProfesor.Name = "cmbAgregarProfesor";
            this.cmbAgregarProfesor.Size = new System.Drawing.Size(231, 23);
            this.cmbAgregarProfesor.TabIndex = 10;
            this.cmbAgregarProfesor.Text = "seleccionar profesor...";
            // 
            // chbAgregarCorrelativa
            // 
            this.chbAgregarCorrelativa.AutoSize = true;
            this.chbAgregarCorrelativa.Location = new System.Drawing.Point(18, 53);
            this.chbAgregarCorrelativa.Name = "chbAgregarCorrelativa";
            this.chbAgregarCorrelativa.Size = new System.Drawing.Size(126, 19);
            this.chbAgregarCorrelativa.TabIndex = 9;
            this.chbAgregarCorrelativa.Text = "Agregar correlativa";
            this.chbAgregarCorrelativa.UseVisualStyleBackColor = true;
            this.chbAgregarCorrelativa.CheckedChanged += new System.EventHandler(this.chbAgregarCorrelativa_CheckedChanged);
            // 
            // chbAgregarProfesor
            // 
            this.chbAgregarProfesor.AutoSize = true;
            this.chbAgregarProfesor.Location = new System.Drawing.Point(18, 28);
            this.chbAgregarProfesor.Name = "chbAgregarProfesor";
            this.chbAgregarProfesor.Size = new System.Drawing.Size(113, 19);
            this.chbAgregarProfesor.TabIndex = 8;
            this.chbAgregarProfesor.Text = "Asignar Profesor";
            this.chbAgregarProfesor.UseVisualStyleBackColor = true;
            this.chbAgregarProfesor.CheckedChanged += new System.EventHandler(this.chbAgregarProfesor_CheckedChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(41, 279);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // AltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gpbUsuario);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaMateria_FormClosed);
            this.Load += new System.EventHandler(this.AltaMateria_Load);
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCuatrimestre;
        private TextBox txtNombre;
        private PictureBox picUtn;
        private Button btnMostrarMaterias;
        private Label lblTitle;
        private Label lbNombre;
        private GroupBox gpbLog;
        private Button btnCrearMateria;
        private GroupBox gpbUsuario;
        private Label lblError;
        private CheckBox chbAgregarCorrelativa;
        private CheckBox chbAgregarProfesor;
        private Button btnMostrarProfesores;
        private ComboBox cmbAgregarCorrelativa;
        private ComboBox cmbAgregarProfesor;
        private ComboBox cmbCuatrimestre;
    }
}