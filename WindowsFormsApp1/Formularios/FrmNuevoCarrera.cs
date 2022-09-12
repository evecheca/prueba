
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Dominio;


namespace WindowsFormsApp1.Formularios
{
    public partial class FrmNuevoCarrera : Form
    {
        ConexionBDao helper=ConexionBDao.ObtenerInstancia();
        private PLanCarrera oPLanCarrera;
        public FrmNuevoCarrera()
        {
            
            oPLanCarrera = new PLanCarrera();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevoCarrera_Load(object sender, EventArgs e)
        {
            cboAsignatura.DataSource = helper.ConsultarTablas("sp_consultar_asignaturas");
            cboAsignatura.ValueMember = "id_Asignatura";
            cboAsignatura.DisplayMember = "nombre";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboAsignatura.SelectedItem.Equals(string.Empty))
            {
                MessageBox.Show("Debe elegir una opcion de asignatura", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtaniocursado.Text == string.Empty)
            {
                MessageBox.Show("Debe Colocar el año actual", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            if (!rbtnPrimer.Checked && !rtbnSegundo.Checked)
            {
                MessageBox.Show("Debe elegir el cuatrimestre", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


              foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if(row.Cells["colNombre"].Value.ToString().Equals(cboAsignatura.Text))
                    
                MessageBox.Show("Debe elegir Una asignatura", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

            }

            DataRowView item = (DataRowView)cboAsignatura.SelectedItem;
            Asignatura materia = new Asignatura();
            materia.Id_Asignatura = Convert.ToInt32(item.Row.ItemArray[0]);
          materia.Nombre = item.Row.ItemArray[1].ToString();
           
            int AñoCursado = Convert.ToInt32(txtaniocursado.Text);
            int Cuatrimestre = 0;
            if (rbtnPrimer.Checked)
                Cuatrimestre = 1;
            else if(rtbnSegundo.Checked)
                Cuatrimestre = 2;
            DetalleCarrera dt = new DetalleCarrera(AñoCursado,Cuatrimestre,materia);
            oPLanCarrera.AgregarDetalle(dt);
            dgvDetalles.Rows.Add(new object[] { materia.Id_Asignatura, materia.Nombre, AñoCursado, Cuatrimestre });
        }

      


       

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarrera.Text))
            {
                MessageBox.Show("Tiene que escribir la Carrera!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Tiene que escribir el Titulo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle...", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAsignatura.Focus();
                return;
            }

            oPLanCarrera.Titulo = txtTitulo.Text;
            oPLanCarrera.Nombre_Carrera = txtCarrera.Text;
            
               bool resultado =helper.ConfirmarCarrera(oPLanCarrera);

            if (resultado == true)
            {
                MessageBox.Show("Se Guardo con Exito la Carrera", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                MessageBox.Show("No se pudo guardar la Carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                oPLanCarrera.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

            }
            //*no me funciona boton quitar, ver porque


        }

        //private void btnQuitar_Click(object sender, EventArgs e)
        //{

        //}


    }
}
