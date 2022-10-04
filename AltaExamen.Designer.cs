namespace alonso_nicolas_primer_parcial_labo
{
    partial class AltaExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaExamen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnCrearExamen = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(43, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 21);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Ingrese los datos del examen:";
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "name...";
            this.txtNombre.Size = new System.Drawing.Size(231, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbLog.Controls.Add(this.lblFecha);
            this.gpbLog.Controls.Add(this.dtpFecha);
            this.gpbLog.Controls.Add(this.lblMateria);
            this.gpbLog.Controls.Add(this.btnMostrarMaterias);
            this.gpbLog.Controls.Add(this.cmbMateria);
            this.gpbLog.Controls.Add(this.btnCrearExamen);
            this.gpbLog.Controls.Add(this.picUtn);
            this.gpbLog.Controls.Add(this.lblNombre);
            this.gpbLog.Controls.Add(this.txtNombre);
            this.gpbLog.Location = new System.Drawing.Point(43, 70);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(269, 240);
            this.gpbLog.TabIndex = 9;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Datos de log";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 15);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha del examen";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(18, 158);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(231, 23);
            this.dtpFecha.TabIndex = 17;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Location = new System.Drawing.Point(18, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 16;
            this.lblMateria.Text = "Materia";
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.BackColor = System.Drawing.SystemColors.Window;
            this.btnMostrarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarMaterias.Location = new System.Drawing.Point(153, 127);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(96, 25);
            this.btnMostrarMaterias.TabIndex = 15;
            this.btnMostrarMaterias.Text = "Ver Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = false;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(18, 98);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 14;
            // 
            // btnCrearExamen
            // 
            this.btnCrearExamen.BackColor = System.Drawing.SystemColors.Window;
            this.btnCrearExamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearExamen.Location = new System.Drawing.Point(153, 197);
            this.btnCrearExamen.Name = "btnCrearExamen";
            this.btnCrearExamen.Size = new System.Drawing.Size(96, 25);
            this.btnCrearExamen.TabIndex = 11;
            this.btnCrearExamen.Text = "Crear Examen";
            this.btnCrearExamen.UseVisualStyleBackColor = false;
            this.btnCrearExamen.Click += new System.EventHandler(this.btnCrearExamen_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(18, 179);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 10;
            this.picUtn.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(43, 315);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error genérico";
            this.lblError.Visible = false;
            // 
            // AltaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 351);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaExamen";
            this.Text = "Crear nuevo examen";
            this.Load += new System.EventHandler(this.AltaExamen_Load);
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblNombre;
        private TextBox txtNombre;
        private GroupBox gpbLog;
        private Button btnCrearExamen;
        private PictureBox picUtn;
        private Label lblMateria;
        private Button btnMostrarMaterias;
        private ComboBox cmbMateria;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblError;
    }
}