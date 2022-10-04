namespace alonso_nicolas_primer_parcial_labo
{
    partial class SeleccionarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarAlumno));
            this.button1 = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnAsignarProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(211, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ver Alumnos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(22, 127);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 41;
            this.picUtn.TabStop = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(22, 79);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(146, 15);
            this.lblDni.TabIndex = 44;
            this.lblDni.Text = "Ingrese el DNI del alumno:";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.txtDni.Location = new System.Drawing.Point(22, 98);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "dni...";
            this.txtDni.Size = new System.Drawing.Size(163, 23);
            this.txtDni.TabIndex = 43;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(22, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 21);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Seleccionar un alumno:";
            // 
            // BtnAsignarProfesor
            // 
            this.BtnAsignarProfesor.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.BtnAsignarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAsignarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAsignarProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnAsignarProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnAsignarProfesor.Location = new System.Drawing.Point(185, 144);
            this.BtnAsignarProfesor.Name = "BtnAsignarProfesor";
            this.BtnAsignarProfesor.Size = new System.Drawing.Size(122, 31);
            this.BtnAsignarProfesor.TabIndex = 46;
            this.BtnAsignarProfesor.Text = "Aceptar";
            this.BtnAsignarProfesor.UseVisualStyleBackColor = true;
            this.BtnAsignarProfesor.Click += new System.EventHandler(this.BtnAsignarProfesor_Click);
            // 
            // SeleccionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 222);
            this.Controls.Add(this.BtnAsignarProfesor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picUtn);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Que alumno desea inscribir?";
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PictureBox picUtn;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTitle;
        private Button BtnAsignarProfesor;
    }
}