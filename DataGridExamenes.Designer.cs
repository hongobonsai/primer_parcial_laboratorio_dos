namespace alonso_nicolas_primer_parcial_labo
{
    partial class DataGridExamenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridExamenes));
            this.lblCargados = new System.Windows.Forms.Label();
            this.dgvExamenesProfesor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenesProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargados
            // 
            this.lblCargados.AutoSize = true;
            this.lblCargados.BackColor = System.Drawing.Color.Transparent;
            this.lblCargados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargados.Location = new System.Drawing.Point(23, 23);
            this.lblCargados.Name = "lblCargados";
            this.lblCargados.Size = new System.Drawing.Size(176, 21);
            this.lblCargados.TabIndex = 10;
            this.lblCargados.Text = "Examenes de la materia:";
            // 
            // dgvExamenesProfesor
            // 
            this.dgvExamenesProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvExamenesProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamenesProfesor.Location = new System.Drawing.Point(23, 50);
            this.dgvExamenesProfesor.Name = "dgvExamenesProfesor";
            this.dgvExamenesProfesor.RowTemplate.Height = 25;
            this.dgvExamenesProfesor.Size = new System.Drawing.Size(354, 237);
            this.dgvExamenesProfesor.TabIndex = 9;
            // 
            // DataGridExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 311);
            this.Controls.Add(this.lblCargados);
            this.Controls.Add(this.dgvExamenesProfesor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataGridExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGridExamenes";
            this.Load += new System.EventHandler(this.DataGridExamenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenesProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCargados;
        private DataGridView dgvExamenesProfesor;
    }
}