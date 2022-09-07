
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
            this.lstDetallesCarrera = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // lstDetallesCarrera
            // 
            this.lstDetallesCarrera.FormattingEnabled = true;
            this.lstDetallesCarrera.ItemHeight = 20;
            this.lstDetallesCarrera.Location = new System.Drawing.Point(150, 203);
            this.lstDetallesCarrera.Name = "lstDetallesCarrera";
            this.lstDetallesCarrera.Size = new System.Drawing.Size(475, 204);
            this.lstDetallesCarrera.TabIndex = 3;
            //this.lstDetallesCarrera.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBajaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDetallesCarrera);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cboCarreras);
            this.Name = "FrmBajaCarrera";
            this.Text = "FrmBajaCarrera";
            this.Load += new System.EventHandler(this.FrmBajaCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.ListBox lstDetallesCarrera;
        private System.Windows.Forms.Button button1;
    }
}