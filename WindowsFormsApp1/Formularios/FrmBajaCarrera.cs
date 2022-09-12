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
    public partial class FrmBajaCarrera : Form
    {
        ConexionBDao helper =ConexionBDao.ObtenerInstancia();

        public FrmBajaCarrera()
        {
            
            InitializeComponent();
        }

      
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedIndex != -1)
            {
                int id_carrera = (int)cboCarreras.SelectedValue;
                if (MessageBox.Show("Seguro que desea eliminar la carrera " + cboCarreras.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                   helper.EliminarCarrera(id_carrera);
                }
            }
       
        }

        private void FrmBajaCarrera_Load(object sender, EventArgs e)
        {
            cboCarreras.DataSource = helper.ConsultarTablas("sp_consultar_carreras");

            cboCarreras.ValueMember = "id_Carrera";
            cboCarreras.DisplayMember = "nombre";
            //CargarLista();




        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedIndex != -1)
            {
                string carrera = cboCarreras.Text;
               


                string sp = "SP_CONSULTARCar";

                List<Parametro> lst = new List<Parametro>();
                
                
                lst.Add(new Parametro("@nombre", cboCarreras.Text));

                dgvCarreraDetalle.Rows.Clear();
                DataTable dt = helper.ConsultaSQL(sp, lst);
                foreach (DataRow fila in dt.Rows)
                {
                    dgvCarreraDetalle.Rows.Add(new object[] {
                    fila["Nombre Carrera"].ToString(),
                    fila["Titulo"].ToString(),
                    });
                    
                }
            }

        }



        




     
    }
}



