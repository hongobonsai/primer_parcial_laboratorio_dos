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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHcAdmin = new System.Windows.Forms.Button();
            this.btnHcProfesor = new System.Windows.Forms.Button();
            this.btnHcAlumno = new System.Windows.Forms.Button();
            this.gpbHardCode = new System.Windows.Forms.GroupBox();
            this.lblLogError = new System.Windows.Forms.Label();
            this.chbVer = new System.Windows.Forms.CheckBox();
            this.gpbHardCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Location = new System.Drawing.Point(245, 170);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario...";
            this.txtUsuario.Size = new System.Drawing.Size(306, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.Location = new System.Drawing.Point(245, 219);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.PlaceholderText = "Contraseña...";
            this.txtContrasenia.Size = new System.Drawing.Size(306, 23);
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
            this.cmbTipoUsuario.Location = new System.Drawing.Point(245, 270);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoUsuario.TabIndex = 2;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Location = new System.Drawing.Point(476, 269);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.lblTitle.Location = new System.Drawing.Point(221, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "UTN FRA - Gestión";
            // 
            // btnHcAdmin
            // 
            this.btnHcAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcAdmin.Location = new System.Drawing.Point(18, 22);
            this.btnHcAdmin.Name = "btnHcAdmin";
            this.btnHcAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnHcAdmin.TabIndex = 5;
            this.btnHcAdmin.Text = "Admin";
            this.btnHcAdmin.UseVisualStyleBackColor = true;
            this.btnHcAdmin.Click += new System.EventHandler(this.btnHcAdmin_Click);
            // 
            // btnHcProfesor
            // 
            this.btnHcProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcProfesor.Location = new System.Drawing.Point(107, 22);
            this.btnHcProfesor.Name = "btnHcProfesor";
            this.btnHcProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnHcProfesor.TabIndex = 6;
            this.btnHcProfesor.Text = "Profesor";
            this.btnHcProfesor.UseVisualStyleBackColor = true;
            this.btnHcProfesor.Click += new System.EventHandler(this.btnHcProfesor_Click);
            // 
            // btnHcAlumno
            // 
            this.btnHcAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcAlumno.Location = new System.Drawing.Point(197, 22);
            this.btnHcAlumno.Name = "btnHcAlumno";
            this.btnHcAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnHcAlumno.TabIndex = 7;
            this.btnHcAlumno.Text = "Alumno";
            this.btnHcAlumno.UseVisualStyleBackColor = true;
            this.btnHcAlumno.Click += new System.EventHandler(this.btnHcAlumno_Click);
            // 
            // gpbHardCode
            // 
            this.gpbHardCode.BackColor = System.Drawing.Color.Transparent;
            this.gpbHardCode.Controls.Add(this.btnHcAdmin);
            this.gpbHardCode.Controls.Add(this.btnHcAlumno);
            this.gpbHardCode.Controls.Add(this.btnHcProfesor);
            this.gpbHardCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbHardCode.Location = new System.Drawing.Point(497, 381);
            this.gpbHardCode.Name = "gpbHardCode";
            this.gpbHardCode.Size = new System.Drawing.Size(291, 57);
            this.gpbHardCode.TabIndex = 8;
            this.gpbHardCode.TabStop = false;
            this.gpbHardCode.Text = "Hardcodear usuarios";
            // 
            // lblLogError
            // 
            this.lblLogError.AutoSize = true;
            this.lblLogError.BackColor = System.Drawing.Color.Transparent;
            this.lblLogError.Location = new System.Drawing.Point(245, 248);
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
            this.chbVer.Location = new System.Drawing.Point(557, 223);
            this.chbVer.Name = "chbVer";
            this.chbVer.Size = new System.Drawing.Size(42, 19);
            this.chbVer.TabIndex = 10;
            this.chbVer.Text = "Ver";
            this.chbVer.UseVisualStyleBackColor = false;
            this.chbVer.CheckedChanged += new System.EventHandler(this.chbVer_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbVer);
            this.Controls.Add(this.lblLogError);
            this.Controls.Add(this.gpbHardCode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ComboBox cmbTipoUsuario;
        private Button btnIngresar;
        private Label lblTitle;
        private Button btnHcAdmin;
        private Button btnHcProfesor;
        private Button btnHcAlumno;
        private GroupBox gpbHardCode;
        private Label lblLogError;
        private CheckBox chbVer;
    }
}