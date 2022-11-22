namespace alonso_nicolas_primer_parcial_labo
{
    partial class PresentarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentarAsistencia));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblRegularidad = new System.Windows.Forms.Label();
            this.cmbAsistencia = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(189, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 25);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblRegularidad
            // 
            this.lblRegularidad.AutoSize = true;
            this.lblRegularidad.BackColor = System.Drawing.Color.Transparent;
            this.lblRegularidad.Location = new System.Drawing.Point(54, 146);
            this.lblRegularidad.Name = "lblRegularidad";
            this.lblRegularidad.Size = new System.Drawing.Size(63, 15);
            this.lblRegularidad.TabIndex = 35;
            this.lblRegularidad.Text = "Asistencia:";
            // 
            // cmbAsistencia
            // 
            this.cmbAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistencia.FormattingEnabled = true;
            this.cmbAsistencia.Location = new System.Drawing.Point(54, 164);
            this.cmbAsistencia.Name = "cmbAsistencia";
            this.cmbAsistencia.Size = new System.Drawing.Size(231, 23);
            this.cmbAsistencia.TabIndex = 34;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(54, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 21);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Presentar asistencia";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Location = new System.Drawing.Point(54, 70);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 32;
            this.lblMateria.Text = "Materia:";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnMostrarMaterias.Location = new System.Drawing.Point(189, 117);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 31;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(54, 88);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 30;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(54, 190);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 37;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // PresentarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblRegularidad);
            this.Controls.Add(this.cmbAsistencia);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.cmbMateria);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PresentarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de asistencia";
            this.Load += new System.EventHandler(this.PresentarAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAceptar;
        private Label lblRegularidad;
        private ComboBox cmbAsistencia;
        private Label lblTitle;
        private Label lblMateria;
        private Button btnMostrarMaterias;
        private ComboBox cmbMateria;
        private Label lblError;
    }
}