namespace alonso_nicolas_primer_parcial_labo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHcAdmin = new System.Windows.Forms.Button();
            this.btnHcProfesor = new System.Windows.Forms.Button();
            this.btnHcAlumno = new System.Windows.Forms.Button();
            this.gpbHardCode = new System.Windows.Forms.GroupBox();
            this.lblLogError = new System.Windows.Forms.Label();
            this.chbVer = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbHardCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Location = new System.Drawing.Point(66, 147);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario...";
            this.txtUsuario.Size = new System.Drawing.Size(278, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.Location = new System.Drawing.Point(66, 196);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.PlaceholderText = "Contraseña...";
            this.txtContrasenia.Size = new System.Drawing.Size(225, 23);
            this.txtContrasenia.TabIndex = 1;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Alumno",
            "Profesor",
            "Admin"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(10, 200);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(136, 23);
            this.cmbTipoUsuario.TabIndex = 2;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightCoral;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "UTN FRA - Gestión";
            // 
            // btnHcAdmin
            // 
            this.btnHcAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHcAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHcAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnHcAdmin.Location = new System.Drawing.Point(16, 22);
            this.btnHcAdmin.Name = "btnHcAdmin";
            this.btnHcAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnHcAdmin.TabIndex = 5;
            this.btnHcAdmin.Text = "Admin";
            this.btnHcAdmin.UseVisualStyleBackColor = false;
            this.btnHcAdmin.Click += new System.EventHandler(this.btnHcAdmin_Click);
            // 
            // btnHcProfesor
            // 
            this.btnHcProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHcProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHcProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnHcProfesor.Location = new System.Drawing.Point(111, 22);
            this.btnHcProfesor.Name = "btnHcProfesor";
            this.btnHcProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnHcProfesor.TabIndex = 6;
            this.btnHcProfesor.Text = "Profesor";
            this.btnHcProfesor.UseVisualStyleBackColor = false;
            this.btnHcProfesor.Click += new System.EventHandler(this.btnHcProfesor_Click);
            // 
            // btnHcAlumno
            // 
            this.btnHcAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHcAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHcAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.btnHcAlumno.Location = new System.Drawing.Point(205, 22);
            this.btnHcAlumno.Name = "btnHcAlumno";
            this.btnHcAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnHcAlumno.TabIndex = 7;
            this.btnHcAlumno.Text = "Alumno";
            this.btnHcAlumno.UseVisualStyleBackColor = false;
            this.btnHcAlumno.Click += new System.EventHandler(this.btnHcAlumno_Click);
            // 
            // gpbHardCode
            // 
            this.gpbHardCode.BackColor = System.Drawing.Color.Transparent;
            this.gpbHardCode.Controls.Add(this.btnHcAdmin);
            this.gpbHardCode.Controls.Add(this.btnHcAlumno);
            this.gpbHardCode.Controls.Add(this.btnHcProfesor);
            this.gpbHardCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbHardCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.gpbHardCode.Location = new System.Drawing.Point(56, 365);
            this.gpbHardCode.Name = "gpbHardCode";
            this.gpbHardCode.Size = new System.Drawing.Size(298, 57);
            this.gpbHardCode.TabIndex = 8;
            this.gpbHardCode.TabStop = false;
            this.gpbHardCode.Text = "Hardcodear usuarios";
            // 
            // lblLogError
            // 
            this.lblLogError.AutoSize = true;
            this.lblLogError.BackColor = System.Drawing.Color.Transparent;
            this.lblLogError.Location = new System.Drawing.Point(10, 231);
            this.lblLogError.Name = "lblLogError";
            this.lblLogError.Size = new System.Drawing.Size(81, 15);
            this.lblLogError.TabIndex = 9;
            this.lblLogError.Text = "Error genérico";
            this.lblLogError.Visible = false;
            // 
            // chbVer
            // 
            this.chbVer.AutoSize = true;
            this.chbVer.BackColor = System.Drawing.Color.Transparent;
            this.chbVer.Location = new System.Drawing.Point(246, 146);
            this.chbVer.Name = "chbVer";
            this.chbVer.Size = new System.Drawing.Size(42, 19);
            this.chbVer.TabIndex = 10;
            this.chbVer.Text = "Ver";
            this.chbVer.UseVisualStyleBackColor = false;
            this.chbVer.CheckedChanged += new System.EventHandler(this.chbVer_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackgroundImage = global::alonso_nicolas_primer_parcial_labo.Properties.Resources.Sin_título;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnIngresar.Location = new System.Drawing.Point(10, 249);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(278, 39);
            this.btnIngresar.TabIndex = 21;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lblLogError);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.chbVer);
            this.panel1.Controls.Add(this.cmbTipoUsuario);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(56, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 307);
            this.panel1.TabIndex = 22;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 427);
            this.Controls.Add(this.gpbHardCode);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN FRA - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gpbHardCode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ComboBox cmbTipoUsuario;
        private Label lblTitle;
        private Button btnHcAdmin;
        private Button btnHcProfesor;
        private Button btnHcAlumno;
        private GroupBox gpbHardCode;
        private Label lblLogError;
        private CheckBox chbVer;
        private Button btnIngresar;
        private Panel panel1;
    }
}