using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FreporteAsignatura : Form
    {
        public FreporteAsignatura()
        {
            InitializeComponent();
        }

        private void FreporteAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCarrera.Asignaturas' Puede moverla o quitarla según sea necesario.
            //this.asignaturasTableAdapter.Fill(this.dsCarrera.Asignaturas);
            // TODO: esta línea de código carga datos en la tabla 'dsCarrera.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.dsCarrera.Asignaturas);
            //this.dsCarreraBindingSource.DataSource = dsCarrera.Asignaturas;
            this.reportViewer1.RefreshReport();
        }
    }
}
