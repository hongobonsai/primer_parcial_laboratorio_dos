namespace alonso_nicolas_primer_parcial_labo
{
    partial class InscribirProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirProfesor));
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.btnMostrarProfesores = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAgregarProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.BtnAsignarProfesor = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMostrarMaterias.Location = new System.Drawing.Point(297, 171);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 17;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.btnMostrarProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProfesores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMostrarProfesores.Location = new System.Drawing.Point(297, 75);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarProfesores.TabIndex = 16;
            this.btnMostrarProfesores.Text = "Ver Profesores";
            this.btnMostrarProfesores.UseVisualStyleBackColor = false;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(56, 172);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 15;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbAgregarCorrelativa_SelectedIndexChanged);
            // 
            // cmbAgregarProfesor
            // 
            this.cmbAgregarProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgregarProfesor.FormattingEnabled = true;
            this.cmbAgregarProfesor.Location = new System.Drawing.Point(56, 76);
            this.cmbAgregarProfesor.Name = "cmbAgregarProfesor";
            this.cmbAgregarProfesor.Size = new System.Drawing.Size(231, 23);
            this.cmbAgregarProfesor.TabIndex = 14;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesor.Location = new System.Drawing.Point(56, 40);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(129, 21);
            this.lblProfesor.TabIndex = 18;
            this.lblProfesor.Text = "Asignar profesor:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(56, 137);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(96, 21);
            this.lblMateria.TabIndex = 19;
            this.lblMateria.Text = "A la materia:";
            // 
            // BtnAsignarProfesor
            // 
            this.BtnAsignarProfesor.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAsignarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAsignarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAsignarProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAsignarProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAsignarProfesor.Location = new System.Drawing.Point(56, 235);
            this.BtnAsignarProfesor.Name = "BtnAsignarProfesor";
            this.BtnAsignarProfesor.Size = new System.Drawing.Size(231, 39);
            this.BtnAsignarProfesor.TabIndex = 20;
            this.BtnAsignarProfesor.Text = "Asignar el profesor";
            this.BtnAsignarProfesor.UseVisualStyleBackColor = true;
            this.BtnAsignarProfesor.Click += new System.EventHandler(this.BtnAsignarProfesor_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(56, 198);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // InscribirProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 302);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.BtnAsignarProfesor);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.btnMostrarProfesores);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbAgregarProfesor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscribirProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar un profesor";
            this.Load += new System.EventHandler(this.InscribirProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostrarMaterias;
        private Button btnMostrarProfesores;
        private ComboBox cmbMateria;
        private ComboBox cmbAgregarProfesor;
        private Label lblProfesor;
        private Label lblMateria;
        private Button BtnAsignarProfesor;
        private Label lblError;
    }
}