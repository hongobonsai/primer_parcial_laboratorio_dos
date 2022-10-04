namespace alonso_nicolas_primer_parcial_labo
{
    partial class CambiarRegularidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarRegularidad));
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRegularidad = new System.Windows.Forms.Label();
            this.cmbRegularidad = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Location = new System.Drawing.Point(28, 122);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 25;
            this.lblMateria.Text = "Materia:";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.SystemColors.Window;
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.Location = new System.Drawing.Point(163, 169);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 24;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(28, 140);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(28, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 21);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Cambiar regularidad";
            // 
            // lblRegularidad
            // 
            this.lblRegularidad.AutoSize = true;
            this.lblRegularidad.BackColor = System.Drawing.Color.Transparent;
            this.lblRegularidad.Location = new System.Drawing.Point(30, 198);
            this.lblRegularidad.Name = "lblRegularidad";
            this.lblRegularidad.Size = new System.Drawing.Size(73, 15);
            this.lblRegularidad.TabIndex = 28;
            this.lblRegularidad.Text = "Regularidad:";
            // 
            // cmbRegularidad
            // 
            this.cmbRegularidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegularidad.FormattingEnabled = true;
            this.cmbRegularidad.Location = new System.Drawing.Point(28, 216);
            this.cmbRegularidad.Name = "cmbRegularidad";
            this.cmbRegularidad.Size = new System.Drawing.Size(231, 23);
            this.cmbRegularidad.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(163, 245);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 25);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(30, 66);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(146, 15);
            this.lblDni.TabIndex = 31;
            this.lblDni.Text = "Ingrese el DNI del alumno:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(30, 83);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "dni...";
            this.txtDni.Size = new System.Drawing.Size(151, 23);
            this.txtDni.TabIndex = 30;
            // 
            // CambiarRegularidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(289, 293);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblRegularidad);
            this.Controls.Add(this.cmbRegularidad);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.cmbMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarRegularidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar la regularidad";
            this.Load += new System.EventHandler(this.CambiarRegularidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMateria;
        private Button btnMostrarMaterias;
        private ComboBox cmbMateria;
        private Label lblTitle;
        private Label lblRegularidad;
        private ComboBox cmbRegularidad;
        private Button btnAceptar;
        private Label lblDni;
        private TextBox txtDni;
    }
}