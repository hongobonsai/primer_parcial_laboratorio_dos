namespace alonso_nicolas_primer_parcial_labo
{
    partial class InscribirAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirAlumno));
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnInscribirAlumno = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnMostrarMaterias.Location = new System.Drawing.Point(191, 132);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 17;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(56, 103);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(-1, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 35);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Inscribirse a materia:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnInscribirAlumno
            // 
            this.BtnInscribirAlumno.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnInscribirAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInscribirAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInscribirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInscribirAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnInscribirAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnInscribirAlumno.Location = new System.Drawing.Point(56, 196);
            this.BtnInscribirAlumno.Name = "BtnInscribirAlumno";
            this.BtnInscribirAlumno.Size = new System.Drawing.Size(231, 39);
            this.BtnInscribirAlumno.TabIndex = 20;
            this.BtnInscribirAlumno.Text = "INSCRIBIRSE";
            this.BtnInscribirAlumno.UseVisualStyleBackColor = true;
            this.BtnInscribirAlumno.Click += new System.EventHandler(this.BtnInscribirAlumno_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(56, 176);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Location = new System.Drawing.Point(56, 85);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 22;
            this.lblMateria.Text = "Materia:";
            // 
            // InscribirAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 269);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.BtnInscribirAlumno);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.cmbMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InscribirAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción a materia";
            this.Load += new System.EventHandler(this.InscribirAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostrarMaterias;
        private ComboBox cmbMateria;
        private Label lblTitle;
        private Button BtnInscribirAlumno;
        private Label lblError;
        private Label lblMateria;
    }
}