using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmReporteComprobante : Form
    {
        public FrmReporteComprobante()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Utilitario.Utilitario.listadoReporte)
                {
                    case 1:
                        Resportes.CtrlReporte objCtrlReporte = new Resportes.CtrlReporte();
                        //Reporte
                        Reporte.comprobante objrptDocumento = new Reporte.comprobante();
                        objrptDocumento.SetDataSource(objCtrlReporte.ListadoReporte2());
                        this.crystalReportViewer1.ReportSource = objrptDocumento;
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
    }
}
