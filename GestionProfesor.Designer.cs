namespace alonso_nicolas_primer_parcial_labo
{
    partial class GestionProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProfesor));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerMaterias = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEvaluarAlumno = new System.Windows.Forms.Button();
            this.btnCrearExamen = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.lblTitle.Location = new System.Drawing.Point(-2, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(720, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bienvenido";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnVerMaterias);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Location = new System.Drawing.Point(176, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de materias y concurrentes";
            // 
            // btnVerMaterias
            // 
            this.btnVerMaterias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerMaterias.BackgroundImage")));
            this.btnVerMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnVerMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnVerMaterias.Location = new System.Drawing.Point(17, 31);
            this.btnVerMaterias.Name = "btnVerMaterias";
            this.btnVerMaterias.Size = new System.Drawing.Size(329, 39);
            this.btnVerMaterias.TabIndex = 3;
            this.btnVerMaterias.Text = "Visualizar materias dictadas";
            this.btnVerMaterias.UseVisualStyleBackColor = true;
            this.btnVerMaterias.Click += new System.EventHandler(this.btnVerMaterias_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEvaluarAlumno);
            this.groupBox1.Controls.Add(this.btnCrearExamen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Location = new System.Drawing.Point(176, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar materias";
            // 
            // btnEvaluarAlumno
            // 
            this.btnEvaluarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEvaluarAlumno.BackgroundImage")));
            this.btnEvaluarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvaluarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvaluarAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEvaluarAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnEvaluarAlumno.Location = new System.Drawing.Point(17, 100);
            this.btnEvaluarAlumno.Name = "btnEvaluarAlumno";
            this.btnEvaluarAlumno.Size = new System.Drawing.Size(329, 39);
            this.btnEvaluarAlumno.TabIndex = 4;
            this.btnEvaluarAlumno.Text = "Evaluar un alumno";
            this.btnEvaluarAlumno.UseVisualStyleBackColor = true;
            this.btnEvaluarAlumno.Click += new System.EventHandler(this.btnEvaluarAlumno_Click);
            // 
            // btnCrearExamen
            // 
            this.btnCrearExamen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearExamen.BackgroundImage")));
            this.btnCrearExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearExamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearExamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCrearExamen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnCrearExamen.Location = new System.Drawing.Point(17, 31);
            this.btnCrearExamen.Name = "btnCrearExamen";
            this.btnCrearExamen.Size = new System.Drawing.Size(329, 39);
            this.btnCrearExamen.TabIndex = 3;
            this.btnCrearExamen.Text = "Crear un examen";
            this.btnCrearExamen.UseVisualStyleBackColor = true;
            this.btnCrearExamen.Click += new System.EventHandler(this.btnCrearExamen_Click);
            // 
            // GestionProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores - Gestión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionProfesor_FormClosing);
            this.Load += new System.EventHandler(this.GestionProfesor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox2;
        private Button btnVerMaterias;
        private GroupBox groupBox1;
        private Button btnEvaluarAlumno;
        private Button btnCrearExamen;
    }
}