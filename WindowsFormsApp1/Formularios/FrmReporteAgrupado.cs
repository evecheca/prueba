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
    public partial class FrmReporteAgrupado : Form
    {
        ConexionBDao helper=ConexionBDao.ObtenerInstancia();

        public FrmReporteAgrupado()
        {
           
            InitializeComponent();
        }

        private void FrmReporteAgrupado_Load(object sender, EventArgs e)
        {

            this.rpvAgrupado.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", dtpDesde.Value));
            lst.Add(new Parametro("@fecha_hasta", dtpHasta.Value));
            DataTable dt = helper.ConsultaSQL("SP_REPORTE_Carreras", lst);
            rpvAgrupado.LocalReport.DataSources.Clear();
            rpvAgrupado.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            rpvAgrupado.RefreshReport();

        }

        private void dataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
