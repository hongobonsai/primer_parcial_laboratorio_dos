namespace alonso_nicolas_primer_parcial_labo
{
    partial class DataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblCargados = new System.Windows.Forms.Label();
            this.btnAceptarAca = new System.Windows.Forms.Button();
            this.btnAceptarUsu = new System.Windows.Forms.Button();
            this.btnAceptarMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(4, 49);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(744, 248);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblCargados
            // 
            this.lblCargados.AutoSize = true;
            this.lblCargados.BackColor = System.Drawing.Color.Transparent;
            this.lblCargados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargados.Location = new System.Drawing.Point(4, 22);
            this.lblCargados.Name = "lblCargados";
            this.lblCargados.Size = new System.Drawing.Size(52, 21);
            this.lblCargados.TabIndex = 1;
            this.lblCargados.Text = "label1";
            // 
            // btnAceptarAca
            // 
            this.btnAceptarAca.BackColor = System.Drawing.Color.White;
            this.btnAceptarAca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarAca.Location = new System.Drawing.Point(673, 303);
            this.btnAceptarAca.Name = "btnAceptarAca";
            this.btnAceptarAca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAca.TabIndex = 2;
            this.btnAceptarAca.Text = "Aceptar";
            this.btnAceptarAca.UseVisualStyleBackColor = false;
            this.btnAceptarAca.Visible = false;
            // 
            // btnAceptarUsu
            // 
            this.btnAceptarUsu.BackColor = System.Drawing.Color.White;
            this.btnAceptarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarUsu.Location = new System.Drawing.Point(205, 231);
            this.btnAceptarUsu.Name = "btnAceptarUsu";
            this.btnAceptarUsu.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarUsu.TabIndex = 4;
            this.btnAceptarUsu.Text = "Aceptar";
            this.btnAceptarUsu.UseVisualStyleBackColor = false;
            this.btnAceptarUsu.Visible = false;
            // 
            // btnAceptarMat
            // 
            this.btnAceptarMat.BackColor = System.Drawing.Color.White;
            this.btnAceptarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarMat.Location = new System.Drawing.Point(274, 231);
            this.btnAceptarMat.Name = "btnAceptarMat";
            this.btnAceptarMat.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMat.TabIndex = 5;
            this.btnAceptarMat.Text = "Aceptar";
            this.btnAceptarMat.UseVisualStyleBackColor = false;
            this.btnAceptarMat.Visible = false;
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 333);
            this.Controls.Add(this.btnAceptarMat);
            this.Controls.Add(this.btnAceptarUsu);
            this.Controls.Add(this.btnAceptarAca);
            this.Controls.Add(this.lblCargados);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label lblCargados;
        private Button btnAceptarAca;
        private Button btnAceptarUsu;
        private Button btnAceptarMat;
    }
}