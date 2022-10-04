using alonso_nicolas_primer_parcial_labo.Properties;

namespace alonso_nicolas_primer_parcial_labo
{
    partial class DataGridListaAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridListaAlumnos));
            this.btnAceptarAca = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarAca
            // 
            this.btnAceptarAca.BackColor = System.Drawing.Color.White;
            this.btnAceptarAca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarAca.Location = new System.Drawing.Point(674, 298);
            this.btnAceptarAca.Name = "btnAceptarAca";
            this.btnAceptarAca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAca.TabIndex = 5;
            this.btnAceptarAca.Text = "Aceptar";
            this.btnAceptarAca.UseVisualStyleBackColor = false;
            this.btnAceptarAca.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(5, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 21);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Lista de alumnos";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(5, 41);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowTemplate.Height = 25;
            this.dgvAlumnos.Size = new System.Drawing.Size(744, 248);
            this.dgvAlumnos.TabIndex = 3;
            // 
            // DataGridListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 333);
            this.Controls.Add(this.btnAceptarAca);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataGridListaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi lista de alumnos";
            this.Load += new System.EventHandler(this.DataGridListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAceptarAca;
        private Label lblTitle;
        private DataGridView dgvAlumnos;
    }
}