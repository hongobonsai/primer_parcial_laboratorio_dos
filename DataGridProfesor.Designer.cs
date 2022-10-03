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
            this.btnAceptarAca = new System.Windows.Forms.Button();
            this.lblCargados = new System.Windows.Forms.Label();
            this.dgvMateriasProfe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarAca
            // 
            this.btnAceptarAca.BackColor = System.Drawing.Color.White;
            this.btnAceptarAca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarAca.Location = new System.Drawing.Point(693, 307);
            this.btnAceptarAca.Name = "btnAceptarAca";
            this.btnAceptarAca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAca.TabIndex = 5;
            this.btnAceptarAca.Text = "Aceptar";
            this.btnAceptarAca.UseVisualStyleBackColor = false;
            this.btnAceptarAca.Visible = false;
            // 
            // lblCargados
            // 
            this.lblCargados.AutoSize = true;
            this.lblCargados.BackColor = System.Drawing.Color.Transparent;
            this.lblCargados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargados.Location = new System.Drawing.Point(24, 26);
            this.lblCargados.Name = "lblCargados";
            this.lblCargados.Size = new System.Drawing.Size(52, 21);
            this.lblCargados.TabIndex = 4;
            this.lblCargados.Text = "label1";
            // 
            // dgvMateriasProfe
            // 
            this.dgvMateriasProfe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMateriasProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasProfe.Location = new System.Drawing.Point(24, 53);
            this.dgvMateriasProfe.Name = "dgvMateriasProfe";
            this.dgvMateriasProfe.RowTemplate.Height = 25;
            this.dgvMateriasProfe.Size = new System.Drawing.Size(744, 248);
            this.dgvMateriasProfe.TabIndex = 3;
            // 
            // DataGridProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 343);
            this.Controls.Add(this.btnAceptarAca);
            this.Controls.Add(this.lblCargados);
            this.Controls.Add(this.dgvMateriasProfe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataGridProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGridProfesor";
            this.Load += new System.EventHandler(this.DataGridProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasProfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAceptarAca;
        private Label lblCargados;
        private DataGridView dgvMateriasProfe;
    }
}