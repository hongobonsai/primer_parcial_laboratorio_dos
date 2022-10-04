namespace alonso_nicolas_primer_parcial_labo
{
    partial class AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.chbVer = new System.Windows.Forms.CheckBox();
            this.btnAceptarAdmin = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.picUtnFra = new System.Windows.Forms.PictureBox();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarAcademico = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLogError = new System.Windows.Forms.Label();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtnFra)).BeginInit();
            this.gpbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "name...";
            this.txtNombre.Size = new System.Drawing.Size(262, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(18, 96);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "surname...";
            this.txtApellido.Size = new System.Drawing.Size(262, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(18, 146);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(262, 23);
            this.dtpNacimiento.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(41, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Ingrese los datos del Academico:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(18, 28);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(47, 15);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbLog.Controls.Add(this.lblMostrar);
            this.gpbLog.Controls.Add(this.chbVer);
            this.gpbLog.Controls.Add(this.btnAceptarAdmin);
            this.gpbLog.Controls.Add(this.picUtn);
            this.gpbLog.Controls.Add(this.lbUser);
            this.gpbLog.Controls.Add(this.txtUser);
            this.gpbLog.Controls.Add(this.txtPass);
            this.gpbLog.Controls.Add(this.label3);
            this.gpbLog.Location = new System.Drawing.Point(41, 85);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(269, 191);
            this.gpbLog.TabIndex = 8;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Datos de log";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.BackColor = System.Drawing.Color.Transparent;
            this.lblMostrar.Location = new System.Drawing.Point(184, 78);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(48, 15);
            this.lblMostrar.TabIndex = 13;
            this.lblMostrar.Text = "Mostrar";
            // 
            // chbVer
            // 
            this.chbVer.AutoSize = true;
            this.chbVer.BackColor = System.Drawing.Color.Transparent;
            this.chbVer.Location = new System.Drawing.Point(234, 79);
            this.chbVer.Name = "chbVer";
            this.chbVer.Size = new System.Drawing.Size(15, 14);
            this.chbVer.TabIndex = 12;
            this.chbVer.UseVisualStyleBackColor = false;
            this.chbVer.CheckedChanged += new System.EventHandler(this.chbVer_CheckedChanged);
            // 
            // btnAceptarAdmin
            // 
            this.btnAceptarAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarAdmin.Location = new System.Drawing.Point(153, 141);
            this.btnAceptarAdmin.Name = "btnAceptarAdmin";
            this.btnAceptarAdmin.Size = new System.Drawing.Size(96, 25);
            this.btnAceptarAdmin.TabIndex = 11;
            this.btnAceptarAdmin.Text = "Aceptar";
            this.btnAceptarAdmin.UseVisualStyleBackColor = false;
            this.btnAceptarAdmin.Visible = false;
            this.btnAceptarAdmin.Click += new System.EventHandler(this.btnAceptarAdmin_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(18, 122);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 10;
            this.picUtn.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(18, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "user...";
            this.txtUser.Size = new System.Drawing.Size(231, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(18, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "password...";
            this.txtPass.Size = new System.Drawing.Size(231, 23);
            this.txtPass.TabIndex = 3;
            // 
            // picUtnFra
            // 
            this.picUtnFra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtnFra.BackgroundImage")));
            this.picUtnFra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUtnFra.Location = new System.Drawing.Point(0, 0);
            this.picUtnFra.Name = "picUtnFra";
            this.picUtnFra.Size = new System.Drawing.Size(300, 281);
            this.picUtnFra.TabIndex = 14;
            this.picUtnFra.TabStop = false;
            this.picUtnFra.Visible = false;
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gpbUsuario.Controls.Add(this.picUtnFra);
            this.gpbUsuario.Controls.Add(this.lblDni);
            this.gpbUsuario.Controls.Add(this.cmbType);
            this.gpbUsuario.Controls.Add(this.cmbGenero);
            this.gpbUsuario.Controls.Add(this.txtDni);
            this.gpbUsuario.Controls.Add(this.label1);
            this.gpbUsuario.Controls.Add(this.btnAceptarAcademico);
            this.gpbUsuario.Controls.Add(this.lblGenero);
            this.gpbUsuario.Controls.Add(this.lblNacimiento);
            this.gpbUsuario.Controls.Add(this.lblNombre);
            this.gpbUsuario.Controls.Add(this.lblApellido);
            this.gpbUsuario.Controls.Add(this.dtpNacimiento);
            this.gpbUsuario.Controls.Add(this.txtNombre);
            this.gpbUsuario.Controls.Add(this.txtApellido);
            this.gpbUsuario.Location = new System.Drawing.Point(347, 40);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(300, 281);
            this.gpbUsuario.TabIndex = 9;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Text = "Datos del usuario";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(18, 178);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 18;
            this.lblDni.Text = "DNI";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Profesor",
            "Alumno"});
            this.cmbType.Location = new System.Drawing.Point(18, 243);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(151, 23);
            this.cmbType.TabIndex = 16;
            this.cmbType.Text = "Profesor";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbGenero.Location = new System.Drawing.Point(187, 195);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(93, 23);
            this.cmbGenero.TabIndex = 15;
            this.cmbGenero.Text = "Masculino";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(18, 195);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "dni...";
            this.txtDni.Size = new System.Drawing.Size(151, 23);
            this.txtDni.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de usuario";
            // 
            // btnAceptarAcademico
            // 
            this.btnAceptarAcademico.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarAcademico.Location = new System.Drawing.Point(187, 241);
            this.btnAceptarAcademico.Name = "btnAceptarAcademico";
            this.btnAceptarAcademico.Size = new System.Drawing.Size(93, 25);
            this.btnAceptarAcademico.TabIndex = 12;
            this.btnAceptarAcademico.Text = "Aceptar";
            this.btnAceptarAcademico.UseVisualStyleBackColor = false;
            this.btnAceptarAcademico.Click += new System.EventHandler(this.btnAceptarAcademico_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(187, 177);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 14;
            this.lblGenero.Text = "Genero";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(18, 128);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(18, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Location = new System.Drawing.Point(18, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLogError
            // 
            this.lblLogError.AutoSize = true;
            this.lblLogError.BackColor = System.Drawing.Color.Transparent;
            this.lblLogError.Location = new System.Drawing.Point(41, 291);
            this.lblLogError.Name = "lblLogError";
            this.lblLogError.Size = new System.Drawing.Size(12, 15);
            this.lblLogError.TabIndex = 13;
            this.lblLogError.Text = "-";
            this.lblLogError.Visible = false;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.lblLogError);
            this.Controls.Add(this.gpbUsuario);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de alta un usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaUsuario_FormClosed);
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtnFra)).EndInit();
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private TextBox txtUser;
        private PictureBox picUtn;
        private Label label6;
        private Button button1;
        private TextBox txtPass;
        private Button button2;
        private Label lblTitle;
        private Label lbUser;
        private GroupBox gpbLog;
        private Button btnAceptarAdmin;
        private GroupBox gpbUsuario;
        private Label lblNacimiento;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnAceptarAcademico;
        private PictureBox picUtnFra;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private ComboBox cmbType;
        private Label lblLogError;
        private Label lblMostrar;
        private CheckBox chbVer;
        private Label lblDni;
        private TextBox txtDni;
    }
}