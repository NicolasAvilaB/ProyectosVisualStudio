namespace Presentacion
{
    partial class FrmReporte
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
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
           
            this.vistareporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            ((System.ComponentModel.ISupportInitialize)(this.vistareporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\Oscar\\tallerIngSoftware\\ray\\Soluciondismac\\SolucionDismac\\Reporte\\rptGarantias" +
                "Generadas.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(723, 500);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_2);
            // 
            // sATDataSet
            // 
            //this.sATDataSet.DataSetName = "SATDataSet";
            //this.sATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistareporteBindingSource
            // 
            this.vistareporteBindingSource.DataMember = "vista_reporte";
            //this.vistareporteBindingSource.DataSource = this.sATDataSet;
            //// 
            // vista_reporteTableAdapter
            // 
            //this.vista_reporteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 500);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            //((System.ComponentModel.ISupportInitialize)(this.sATDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistareporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        
        private System.Windows.Forms.BindingSource vistareporteBindingSource;
        

    }
}