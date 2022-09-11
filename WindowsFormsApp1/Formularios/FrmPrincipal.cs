﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCarrera nuevoCarrera = new FrmNuevoCarrera();
            nuevoCarrera.ShowDialog();
        }

        private void bAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaCarrera bajaCarrera = new FrmBajaCarrera();
            bajaCarrera.ShowDialog();
        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmReporteAgrupado().ShowDialog(); 
        }

        //private void bAJAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmaBajaCarrera BajaCarrera = new FrmaBajaCarrera();
        //    BajaCarrera.ShowDialog();
        //}
    }
}
