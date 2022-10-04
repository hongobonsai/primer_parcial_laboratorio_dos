namespace alonso_nicolas_primer_parcial_labo
{
    partial class EvaluarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarAlumno));
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.nudPrimero = new System.Windows.Forms.NumericUpDown();
            this.nudSegundo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.BtnAsignarProfesor = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundo)).BeginInit();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(49, 95);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(146, 15);
            this.lblDni.TabIndex = 37;
            this.lblDni.Text = "Ingrese el DNI del alumno:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(51, 124);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "dni...";
            this.txtDni.Size = new System.Drawing.Size(120, 23);
            this.txtDni.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 21);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Finalizar Cuatrimestre";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Location = new System.Drawing.Point(49, 173);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 34;
            this.lblMateria.Text = "Materia:";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.SystemColors.Window;
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.Location = new System.Drawing.Point(186, 229);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 33;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(51, 191);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 32;
            // 
            // nudPrimero
            // 
            this.nudPrimero.Location = new System.Drawing.Point(200, 31);
            this.nudPrimero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrimero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrimero.Name = "nudPrimero";
            this.nudPrimero.Size = new System.Drawing.Size(39, 23);
            this.nudPrimero.TabIndex = 38;
            this.nudPrimero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSegundo
            // 
            this.nudSegundo.Location = new System.Drawing.Point(200, 60);
            this.nudSegundo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSegundo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSegundo.Name = "nudSegundo";
            this.nudSegundo.Size = new System.Drawing.Size(39, 23);
            this.nudSegundo.TabIndex = 39;
            this.nudSegundo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(186, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ver Alumnos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nota primer examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nota segundo examen";
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbLog.Controls.Add(this.BtnAsignarProfesor);
            this.gpbLog.Controls.Add(this.label2);
            this.gpbLog.Controls.Add(this.label1);
            this.gpbLog.Controls.Add(this.nudPrimero);
            this.gpbLog.Controls.Add(this.nudSegundo);
            this.gpbLog.Location = new System.Drawing.Point(312, 95);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(256, 159);
            this.gpbLog.TabIndex = 43;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Evaluación";
            // 
            // BtnAsignarProfesor
            // 
            this.BtnAsignarProfesor.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAsignarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAsignarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAsignarProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAsignarProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAsignarProfesor.Location = new System.Drawing.Point(13, 105);
            this.BtnAsignarProfesor.Name = "BtnAsignarProfesor";
            this.BtnAsignarProfesor.Size = new System.Drawing.Size(226, 39);
            this.BtnAsignarProfesor.TabIndex = 44;
            this.BtnAsignarProfesor.Text = "EVALUAR CUATRIMESTRE";
            this.BtnAsignarProfesor.UseVisualStyleBackColor = true;
            this.BtnAsignarProfesor.Click += new System.EventHandler(this.BtnAsignarProfesor_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(51, 208);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 10;
            this.picUtn.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(312, 257);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 44;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // EvaluarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 287);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picUtn);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnMostrarMaterias);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EvaluarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluar un alumno";
            this.Load += new System.EventHandler(this.EvaluarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundo)).EndInit();
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDni;
        private TextBox txtDni;
        private Label lblTitle;
        private Label lblMateria;
        private Button btnMostrarMaterias;
        private ComboBox cmbMateria;
        private NumericUpDown nudPrimero;
        private NumericUpDown nudSegundo;
        private Button button1;
        private Label label1;
        private Label label2;
        private GroupBox gpbLog;
        private PictureBox picUtn;
        private Button BtnAsignarProfesor;
        private Label lblError;
    }
}