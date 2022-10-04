namespace alonso_nicolas_primer_parcial_labo
{
    partial class GestionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAdmin));
            this.LblTitle = new System.Windows.Forms.Label();
            this.GpbAdministracionMaterias = new System.Windows.Forms.GroupBox();
            this.BtnAsignarProfesor = new System.Windows.Forms.Button();
            this.BtnCrearMateria = new System.Windows.Forms.Button();
            this.BtnCambiarEstado = new System.Windows.Forms.Button();
            this.GpbAdministracionUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnAltaAlumno = new System.Windows.Forms.Button();
            this.BtnAltaAcademico = new System.Windows.Forms.Button();
            this.BtnAltaAdmin = new System.Windows.Forms.Button();
            this.btnInscribirAlumno = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GpbAdministracionMaterias.SuspendLayout();
            this.GpbAdministracionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LblTitle.Location = new System.Drawing.Point(0, 31);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(718, 64);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Bienvenido";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GpbAdministracionMaterias
            // 
            this.GpbAdministracionMaterias.BackColor = System.Drawing.Color.Transparent;
            this.GpbAdministracionMaterias.Controls.Add(this.BtnAsignarProfesor);
            this.GpbAdministracionMaterias.Controls.Add(this.BtnCrearMateria);
            this.GpbAdministracionMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbAdministracionMaterias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GpbAdministracionMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GpbAdministracionMaterias.Location = new System.Drawing.Point(384, 110);
            this.GpbAdministracionMaterias.Name = "GpbAdministracionMaterias";
            this.GpbAdministracionMaterias.Size = new System.Drawing.Size(305, 139);
            this.GpbAdministracionMaterias.TabIndex = 5;
            this.GpbAdministracionMaterias.TabStop = false;
            this.GpbAdministracionMaterias.Text = "Administración de materias";
            // 
            // BtnAsignarProfesor
            // 
            this.BtnAsignarProfesor.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAsignarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAsignarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAsignarProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAsignarProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAsignarProfesor.Location = new System.Drawing.Point(17, 84);
            this.BtnAsignarProfesor.Name = "BtnAsignarProfesor";
            this.BtnAsignarProfesor.Size = new System.Drawing.Size(264, 39);
            this.BtnAsignarProfesor.TabIndex = 5;
            this.BtnAsignarProfesor.Text = "Asignar un profesor a una materia";
            this.BtnAsignarProfesor.UseVisualStyleBackColor = true;
            this.BtnAsignarProfesor.Click += new System.EventHandler(this.BtnAsignarProfesor_Click);
            // 
            // BtnCrearMateria
            // 
            this.BtnCrearMateria.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnCrearMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCrearMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCrearMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnCrearMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnCrearMateria.Location = new System.Drawing.Point(17, 31);
            this.BtnCrearMateria.Name = "BtnCrearMateria";
            this.BtnCrearMateria.Size = new System.Drawing.Size(264, 39);
            this.BtnCrearMateria.TabIndex = 3;
            this.BtnCrearMateria.Text = "Crear materia";
            this.BtnCrearMateria.UseVisualStyleBackColor = true;
            this.BtnCrearMateria.Click += new System.EventHandler(this.BtnCrearMateria_Click);
            // 
            // BtnCambiarEstado
            // 
            this.BtnCambiarEstado.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnCambiarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnCambiarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnCambiarEstado.Location = new System.Drawing.Point(15, 30);
            this.BtnCambiarEstado.Name = "BtnCambiarEstado";
            this.BtnCambiarEstado.Size = new System.Drawing.Size(275, 39);
            this.BtnCambiarEstado.TabIndex = 4;
            this.BtnCambiarEstado.Text = "Cambiar regularidad de un alumno";
            this.BtnCambiarEstado.UseVisualStyleBackColor = true;
            this.BtnCambiarEstado.Click += new System.EventHandler(this.BtnCambiarEstado_Click);
            // 
            // GpbAdministracionUsuarios
            // 
            this.GpbAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.GpbAdministracionUsuarios.Controls.Add(this.BtnAltaAlumno);
            this.GpbAdministracionUsuarios.Controls.Add(this.BtnAltaAcademico);
            this.GpbAdministracionUsuarios.Controls.Add(this.BtnAltaAdmin);
            this.GpbAdministracionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbAdministracionUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GpbAdministracionUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GpbAdministracionUsuarios.Location = new System.Drawing.Point(27, 110);
            this.GpbAdministracionUsuarios.Name = "GpbAdministracionUsuarios";
            this.GpbAdministracionUsuarios.Size = new System.Drawing.Size(315, 226);
            this.GpbAdministracionUsuarios.TabIndex = 4;
            this.GpbAdministracionUsuarios.TabStop = false;
            this.GpbAdministracionUsuarios.Text = "Administración de usuarios";
            // 
            // BtnAltaAlumno
            // 
            this.BtnAltaAlumno.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAltaAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAltaAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAltaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAltaAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAltaAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAltaAlumno.Location = new System.Drawing.Point(17, 168);
            this.BtnAltaAlumno.Name = "BtnAltaAlumno";
            this.BtnAltaAlumno.Size = new System.Drawing.Size(276, 39);
            this.BtnAltaAlumno.TabIndex = 5;
            this.BtnAltaAlumno.Text = "MOSTRAR LISTA DE USUARIOS";
            this.BtnAltaAlumno.UseVisualStyleBackColor = true;
            this.BtnAltaAlumno.Click += new System.EventHandler(this.BtnMostrarUsuarios_Click);
            // 
            // BtnAltaAcademico
            // 
            this.BtnAltaAcademico.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAltaAcademico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAltaAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAltaAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAltaAcademico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAltaAcademico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAltaAcademico.Location = new System.Drawing.Point(17, 100);
            this.BtnAltaAcademico.Name = "BtnAltaAcademico";
            this.BtnAltaAcademico.Size = new System.Drawing.Size(276, 39);
            this.BtnAltaAcademico.TabIndex = 4;
            this.BtnAltaAcademico.Text = "Dar de alta Academico";
            this.BtnAltaAcademico.UseVisualStyleBackColor = true;
            this.BtnAltaAcademico.Click += new System.EventHandler(this.BtnAltaAcademico_Click);
            // 
            // BtnAltaAdmin
            // 
            this.BtnAltaAdmin.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAltaAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAltaAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAltaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAltaAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAltaAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAltaAdmin.Location = new System.Drawing.Point(17, 31);
            this.BtnAltaAdmin.Name = "BtnAltaAdmin";
            this.BtnAltaAdmin.Size = new System.Drawing.Size(276, 39);
            this.BtnAltaAdmin.TabIndex = 3;
            this.BtnAltaAdmin.Text = "Dar de alta Admin";
            this.BtnAltaAdmin.UseVisualStyleBackColor = true;
            this.BtnAltaAdmin.Click += new System.EventHandler(this.BtnAltaAdmin_Click);
            // 
            // btnInscribirAlumno
            // 
            this.btnInscribirAlumno.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.btnInscribirAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInscribirAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscribirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInscribirAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnInscribirAlumno.Location = new System.Drawing.Point(15, 84);
            this.btnInscribirAlumno.Name = "btnInscribirAlumno";
            this.btnInscribirAlumno.Size = new System.Drawing.Size(275, 39);
            this.btnInscribirAlumno.TabIndex = 6;
            this.btnInscribirAlumno.Text = "Inscribir un alumno a una materia";
            this.btnInscribirAlumno.UseVisualStyleBackColor = true;
            this.btnInscribirAlumno.Click += new System.EventHandler(this.btnInscribirAlumno_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(27, 336);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(181, 77);
            this.picUtn.TabIndex = 42;
            this.picUtn.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnCambiarEstado);
            this.groupBox1.Controls.Add(this.btnInscribirAlumno);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Location = new System.Drawing.Point(384, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración de alumnos";
            // 
            // GestionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picUtn);
            this.Controls.Add(this.GpbAdministracionMaterias);
            this.Controls.Add(this.GpbAdministracionUsuarios);
            this.Controls.Add(this.LblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN - Gestión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionAdmin_FormClosing);
            this.Load += new System.EventHandler(this.GestionAdmin_Load);
            this.GpbAdministracionMaterias.ResumeLayout(false);
            this.GpbAdministracionUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblTitle;
        private GroupBox GpbAdministracionMaterias;
        private Button BtnAsignarProfesor;
        private Button BtnCambiarEstado;
        private Button BtnCrearMateria;
        private GroupBox GpbAdministracionUsuarios;
        private Button BtnAltaAdmin;
        private Button BtnAltaAcademico;
        private Button BtnAltaAlumno;
        private Button btnInscribirAlumno;
        private PictureBox picUtn;
        private GroupBox groupBox1;
    }
}