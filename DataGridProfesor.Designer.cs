namespace alonso_nicolas_primer_parcial_labo
{
    partial class DataGridProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridProfesor));
            this.lblCargados = new System.Windows.Forms.Label();
            this.dgvMateriasProfe = new System.Windows.Forms.DataGridView();
            this.btnVerMaterias = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picUtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasProfe)).BeginInit();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargados
            // 
            this.lblCargados.AutoSize = true;
            this.lblCargados.BackColor = System.Drawing.Color.Transparent;
            this.lblCargados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargados.Location = new System.Drawing.Point(24, 26);
            this.lblCargados.Name = "lblCargados";
            this.lblCargados.Size = new System.Drawing.Size(134, 21);
            this.lblCargados.TabIndex = 4;
            this.lblCargados.Text = "Materias dictadas:";
            // 
            // dgvMateriasProfe
            // 
            this.dgvMateriasProfe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMateriasProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasProfe.Location = new System.Drawing.Point(24, 53);
            this.dgvMateriasProfe.Name = "dgvMateriasProfe";
            this.dgvMateriasProfe.RowTemplate.Height = 25;
            this.dgvMateriasProfe.Size = new System.Drawing.Size(345, 230);
            this.dgvMateriasProfe.TabIndex = 3;
            // 
            // btnVerMaterias
            // 
            this.btnVerMaterias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerMaterias.BackgroundImage")));
            this.btnVerMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnVerMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnVerMaterias.Location = new System.Drawing.Point(18, 118);
            this.btnVerMaterias.Name = "btnVerMaterias";
            this.btnVerMaterias.Size = new System.Drawing.Size(231, 39);
            this.btnVerMaterias.TabIndex = 6;
            this.btnVerMaterias.Text = "VER MIS ALUMNOS";
            this.btnVerMaterias.UseVisualStyleBackColor = true;
            this.btnVerMaterias.Click += new System.EventHandler(this.btnVerMaterias_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(18, 39);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 21);
            this.lblMateria.TabIndex = 28;
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(18, 72);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(231, 23);
            this.cmbMateria.TabIndex = 26;
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbLog.Controls.Add(this.button1);
            this.gpbLog.Controls.Add(this.cmbMateria);
            this.gpbLog.Controls.Add(this.btnVerMaterias);
            this.gpbLog.Controls.Add(this.lblMateria);
            this.gpbLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gpbLog.Location = new System.Drawing.Point(403, 53);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(269, 230);
            this.gpbLog.TabIndex = 29;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Visualización de datos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(18, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "VER MIS EXAMENES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picUtn
            // 
            this.picUtn.BackColor = System.Drawing.Color.Transparent;
            this.picUtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUtn.BackgroundImage")));
            this.picUtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUtn.Location = new System.Drawing.Point(260, 5);
            this.picUtn.Name = "picUtn";
            this.picUtn.Size = new System.Drawing.Size(109, 63);
            this.picUtn.TabIndex = 10;
            this.picUtn.TabStop = false;
            // 
            // DataGridProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.dgvMateriasProfe);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.lblCargados);
            this.Controls.Add(this.picUtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataGridProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis materias";
            this.Load += new System.EventHandler(this.DataGridProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasProfe)).EndInit();
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCargados;
        private DataGridView dgvMateriasProfe;
        private Button btnVerMaterias;
        private Label lblMateria;
        private ComboBox cmbMateria;
        private GroupBox gpbLog;
        private PictureBox picUtn;
        private Button button1;
    }
}