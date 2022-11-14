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
    public partial class FrmRegistraInforme : Form
    {
        public FrmRegistraInforme()
        {
            InitializeComponent();
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistraInforme_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDesperfectos();
                CargarOrdenesDeTrabajo();
                this.txboxBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }


        public void CargarDesperfectos()
        {
            try
            {
                Negocio.Garantia.Desperfecto obj = new Negocio.Garantia.Desperfecto();
                this.cboDesperfectoInforme.DataSource = obj.Traer_Desperfectos();
                this.cboDesperfectoInforme.DisplayMember = "nombreDesperfecto";
                this.cboDesperfectoInforme.ValueMember = "idDesperfecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }


        public void CargarOrdenesDeTrabajo()
        {
            try
            {
                Negocio.Garantia.Ordentrabajo obj = new Negocio.Garantia.Ordentrabajo();
                this.lstBoxLista.DataSource = obj.Traer_Ordtbl_trabajos_con_Nombre();
                this.lstBoxLista.DisplayMember = "cliente";
                this.lstBoxLista.ValueMember = "idOrdenTrabajo";
                this.lblNroOrden.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void txboxBuscar_Enter(object sender, EventArgs e)
        {
            this.txboxBuscar.Text = "";
        }

        private void txboxBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txboxBuscar.Text.Trim().Equals(""))
            {
                this.txboxBuscar.Text = "Buscar";
            }
        }

        public void buscarOrdenes()
        {
            try
            {
                Negocio.Garantia.Ordentrabajo obj = new Negocio.Garantia.Ordentrabajo();
                Utilitario.Utilitario.comodin = this.txboxBuscar.Text.Trim();


                this.lstBoxLista.DataSource = obj.Traer_Ordtbl_trabajos_Comodin();
                this.lstBoxLista.DisplayMember = "cliente";
                this.lstBoxLista.ValueMember = "idOrdenTrabajo";

                if (obj.Traer_Ordtbl_trabajos_Comodin().Rows.Count == 0)
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }


        }

        public void Limpiar()
        {
            try
            {
                this.btnActualizar.Enabled = false;
                this.lblNroOrden.Text = "";
                this.btnGuardar.Enabled = false;
                this.listDesperfectos.Text = "";
                dtpFechaInforme.Value = DateTime.Now;
                CargarDesperfectos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void txboxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buscarOrdenes();
            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarCampos();
                btnImprimir.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        public void llenarCampos()
        {
            try
            {
                Negocio.Garantia.Informe obj = new Negocio.Garantia.Informe();
                obj.PidOrdenTrabajo = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Informe_porNumero();

                if (dt.Rows.Count == 0)
                {
                    this.cboDesperfectoInforme.SelectedValue = 0;
                    this.listDesperfectos.Text = "";
                    this.dtpFechaInforme.Value = DateTime.Now;
                    this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                    btnActualizar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
                else
                {

                    this.cboDesperfectoInforme.SelectedValue = (dt.Rows[0]["idDesperfecto"].ToString()); ;
                    this.listDesperfectos.Text = (dt.Rows[0]["obsInforme"].ToString());
                    this.dtpFechaInforme.Value = DateTime.Parse(dt.Rows[0]["fechaInforme"].ToString()); 
                    this.lblNroOrden.Text = (dt.Rows[0]["idOrdenTrabajo"].ToString());
                    btnActualizar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Informe obj = new Negocio.Garantia.Informe();
                obj.PidInforme = 0;
                obj.PfechaInforme = DateTime.Parse(this.dtpFechaInforme.Value.ToString());
                obj.PobsInforme = this.listDesperfectos.Text.Trim();
                obj.PiConcurrenciaInforme = 0;
                obj.PidOrdenTrabajo = int.Parse(this.lblNroOrden.Text);
                obj.PidDesperfecto = int.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Informe obj = new Negocio.Garantia.Informe();
                obj.PidInforme = 0;
                obj.PfechaInforme = DateTime.Parse(this.dtpFechaInforme.Value.ToString());
                obj.PobsInforme = this.listDesperfectos.Text.Trim();
                obj.PiConcurrenciaInforme = 0;
                obj.PidOrdenTrabajo = int.Parse(this.lblNroOrden.Text);
                obj.PidDesperfecto = int.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea Cancelar la Operacion ?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                
                //this.lstBoxLista.SetSelected(0, false);
                //this.Limpiar();
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de este formulario?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitario.Utilitario.nroOrdenTrabajo = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                Utilitario.Utilitario.listadoReporte = 1;
                FrmReporteComprobante fr = new FrmReporteComprobante();
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de tipo\n" + ex.Message);
            }
        }
    }
}
