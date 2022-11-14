using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resportes;
namespace Presentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

       

        private void crystalReportViewer1_Load_2(object sender, EventArgs e)
        {
            try
            {
                switch (Utilitario.Utilitario.listadoReporte)
                {
                    case 1:
                        Resportes.CtrlReporte objCtrlReporte = new Resportes.CtrlReporte();
                        //Reporte
                        Reporte.rptGarantiasGeneradas objrptDocumento = new Reporte.rptGarantiasGeneradas();
                        objrptDocumento.SetDataSource(objCtrlReporte.ListadoReporte());
                        this.crystalReportViewer1.ReportSource = objrptDocumento;
                        break;
                    case 2:
                        Resportes.CtrlReporte objCtrlReporte2 = new Resportes.CtrlReporte();
                        //Reporte
                        Reporte.rptGarantiasGeneradas objrptDocumento2 = new Reporte.rptGarantiasGeneradas();
                        objrptDocumento2.SetDataSource(objCtrlReporte2.ListadoReporte3());
                        this.crystalReportViewer1.ReportSource = objrptDocumento2;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE TIPO: \n" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            

        }
    }
}
