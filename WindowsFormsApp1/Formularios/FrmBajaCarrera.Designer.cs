
namespace WindowsFormsApp1.Formularios
{
    partial class FrmBajaCarrera
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
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvCarreraDetalle = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnombreCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreraDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(284, 79);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(249, 28);
            this.cboCarreras.TabIndex = 0;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(135, 79);
            this.lblCarrera.MinimumSize = new System.Drawing.Size(30, 10);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(62, 20);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "Carrera";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(627, 83);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 40);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(675, 238);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 51);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvCarreraDetalle
            // 
            this.dgvCarreraDetalle.AllowUserToAddRows = false;
            this.dgvCarreraDetalle.AllowUserToDeleteRows = false;
            this.dgvCarreraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreraDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colnombreCarrera,
            this.colTitulo});
            this.dgvCarreraDetalle.Location = new System.Drawing.Point(32, 238);
            this.dgvCarreraDetalle.Name = "dgvCarreraDetalle";
            this.dgvCarreraDetalle.ReadOnly = true;
            this.dgvCarreraDetalle.RowHeadersWidth = 62;
            this.dgvCarreraDetalle.RowTemplate.Height = 28;
            this.dgvCarreraDetalle.Size = new System.Drawing.Size(563, 200);
            this.dgvCarreraDetalle.TabIndex = 5;
            // 
            // colid
            // 
            this.colid.HeaderText = "id";
            this.colid.MinimumWidth = 8;
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            this.colid.Width = 150;
            // 
            // colnombreCarrera
            // 
            this.colnombreCarrera.HeaderText = "Nombre Carrera";
            this.colnombreCarrera.MinimumWidth = 8;
            this.colnombreCarrera.Name = "colnombreCarrera";
            this.colnombreCarrera.ReadOnly = true;
            this.colnombreCarrera.Width = 150;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.MinimumWidth = 8;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 150;
            // 
            // FrmBajaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarreraDetalle);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cboCarreras);
            this.Name = "FrmBajaCarrera";
            this.Text = "FrmBajaCarrera";
            this.Load += new System.EventHandler(this.FrmBajaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreraDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvCarreraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombreCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
    }
}