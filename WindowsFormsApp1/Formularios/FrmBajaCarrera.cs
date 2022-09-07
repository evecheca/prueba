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
        ConexionBD helper;
        public FrmBajaCarrera()
        {
            helper = new ConexionBD();
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
   
    /* Da error y no carga la lista ver!
      //public void CargarLista()
      //  {
      //      DataTable tabla = helper.ConsultarTablas("sp_consultar_detalleCarreras");

      //      lstDetallesCarrera.Items.Clear();
      //      foreach(DataRow row in tabla.Rows)
      //      {
      //          PLanCarrera carrera = new PLanCarrera();
      //          carrera.Id_Carrera= Convert.ToInt32(row["codigo"].ToString()); 
      //          carrera.Nombre_Carrera = row["Carrera"].ToString();
      //          carrera.Titulo= row["titulo"].ToString();

      //          int aniocursado = Convert.ToInt32(row["Año Cursado"].ToString());
      //          int cuatrimestre = Convert.ToInt32(row["Cuatrimestre"].ToString());

      //          Asignatura materia = new Asignatura();
      //          materia.Id_Asignatura = Convert.ToInt32(row["codigo asignatura"].ToString());
      //          materia.Nombre= row["Nombre Asignatura"].ToString();
      //          DetalleCarrera detalle=new DetalleCarrera(aniocursado,cuatrimestre,materia);
                

      //          lstDetallesCarrera.Items.Add(carrera);
                



      //      }


        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (lstDetallesCarrera.SelectedIndex != -1)
        //    {
        //        PLanCarrera carrera = (PLanCarrera)cboCarreras.SelectedItem;

        //        cboCarreras.SelectedValue = carrera.Id_Carrera;
        //        cboCarreras.Text = carrera.Nombre_Carrera;
        //    }
        //}
    }
}
