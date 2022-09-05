
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    partial class FrmNuevoCarrera
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
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblCarreraNro = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.txtaniocursado = new System.Windows.Forms.TextBox();
            this.rbtnPrimer = new System.Windows.Forms.RadioButton();
            this.rtbnSegundo = new System.Windows.Forms.RadioButton();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(264, 51);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(222, 26);
            this.txtCarrera.TabIndex = 0;
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Location = new System.Drawing.Point(52, 9);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(132, 20);
            this.lblCarreraNro.TabIndex = 1;
            this.lblCarreraNro.Text = "CARRERA NRO:";
            this.lblCarreraNro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Location = new System.Drawing.Point(81, 51);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(160, 20);
            this.lblNombreCarrera.TabIndex = 2;
            this.lblNombreCarrera.Text = "Nombre de la Carrera";
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Location = new System.Drawing.Point(113, 134);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(128, 20);
            this.lblAñoCursado.TabIndex = 3;
            this.lblAñoCursado.Text = "AÑO CURSADO";
            // 
            // txtaniocursado
            // 
            this.txtaniocursado.Location = new System.Drawing.Point(264, 127);
            this.txtaniocursado.Name = "txtaniocursado";
            this.txtaniocursado.Size = new System.Drawing.Size(163, 26);
            this.txtaniocursado.TabIndex = 4;
            // 
            // rbtnPrimer
            // 
            this.rbtnPrimer.AutoSize = true;
            this.rbtnPrimer.Location = new System.Drawing.Point(264, 176);
            this.rbtnPrimer.Name = "rbtnPrimer";
            this.rbtnPrimer.Size = new System.Drawing.Size(88, 24);
            this.rbtnPrimer.TabIndex = 5;
            this.rbtnPrimer.TabStop = true;
            this.rbtnPrimer.Text = "Primero";
            this.rbtnPrimer.UseVisualStyleBackColor = true;
            // 
            // rtbnSegundo
            // 
            this.rtbnSegundo.AutoSize = true;
            this.rtbnSegundo.Location = new System.Drawing.Point(417, 176);
            this.rtbnSegundo.Name = "rtbnSegundo";
            this.rtbnSegundo.Size = new System.Drawing.Size(99, 24);
            this.rtbnSegundo.TabIndex = 6;
            this.rtbnSegundo.TabStop = true;
            this.rtbnSegundo.Text = "Segundo";
            this.rtbnSegundo.UseVisualStyleBackColor = true;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(86, 176);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(100, 20);
            this.lblCuatrimestre.TabIndex = 7;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(98, 221);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(86, 20);
            this.lblAsignatura.TabIndex = 8;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(232, 213);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(186, 28);
            this.cboAsignatura.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(475, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 35);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColNombre,
            this.Colaño,
            this.Colcuatri,
            this.ColQuitar});
            this.dgvDetalles.Location = new System.Drawing.Point(152, 250);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.Size = new System.Drawing.Size(646, 150);
            this.dgvDetalles.TabIndex = 11;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(692, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(589, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 32);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(148, 93);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(264, 86);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(222, 26);
            this.txtTitulo.TabIndex = 15;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 150;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Asignatura";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 150;
            // 
            // Colaño
            // 
            this.Colaño.HeaderText = "Año";
            this.Colaño.MinimumWidth = 8;
            this.Colaño.Name = "Colaño";
            this.Colaño.ReadOnly = true;
            this.Colaño.Width = 150;
            // 
            // Colcuatri
            // 
            this.Colcuatri.HeaderText = "cuatrimestre";
            this.Colcuatri.MinimumWidth = 8;
            this.Colcuatri.Name = "Colcuatri";
            this.Colcuatri.ReadOnly = true;
            this.Colcuatri.Width = 150;
            // 
            // ColQuitar
            // 
            this.ColQuitar.HeaderText = "Acciones";
            this.ColQuitar.MinimumWidth = 8;
            this.ColQuitar.Name = "ColQuitar";
            this.ColQuitar.ReadOnly = true;
            this.ColQuitar.Text = "Quitar";
            this.ColQuitar.UseColumnTextForButtonValue = true;
            this.ColQuitar.Width = 150;
            // 
            // FrmNuevoCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.rtbnSegundo);
            this.Controls.Add(this.rbtnPrimer);
            this.Controls.Add(this.txtaniocursado);
            this.Controls.Add(this.lblAñoCursado);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblCarreraNro);
            this.Controls.Add(this.txtCarrera);
            this.Name = "FrmNuevoCarrera";
            this.Text = "NuevaCarrera";
            this.Load += new System.EventHandler(this.FrmNuevoCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.Label lblAñoCursado;
        private System.Windows.Forms.TextBox txtaniocursado;
        private System.Windows.Forms.RadioButton rbtnPrimer;
        private System.Windows.Forms.RadioButton rtbnSegundo;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn Colaño;
        private DataGridViewTextBoxColumn Colcuatri;
        private DataGridViewButtonColumn ColQuitar;
    }
}