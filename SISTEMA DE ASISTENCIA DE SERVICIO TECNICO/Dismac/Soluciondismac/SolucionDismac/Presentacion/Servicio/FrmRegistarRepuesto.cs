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
    public partial class FrmRegistarRepuesto : Form
    {
        public FrmRegistarRepuesto()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        public void CargarRepuestos()
        {
            Negocio.Garantia.Repuesto obj = new Negocio.Garantia.Repuesto();
            this.cboRepuesto.DataSource = obj.Traer_Repuestos();
            this.cboRepuesto.DisplayMember = "descRepuesto";
            this.cboRepuesto.ValueMember = "idRepuesto";
        }

        private void FrmRegistarRepuesto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarRepuestos();
                CargarOrdenesDeTrabajo();
                this.txboxBuscar.Focus();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de este formulario?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
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
        public void Limpiar()
        {
            try
            {
               
                //this.CargarRepuestos();
                this.txPrecioRepuesto.Text = "";
                this.txCantidadRepuesto.Text = "";
                this.txPrecioTotalRepuesto.Text = "";
                this.lblNroOrden.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;

                //this.lstBoxLista.SetSelected(0, false);
                //this.Limpiar();
                //this.CargarRepuestos();
            }
            catch (Exception ex)
            {

            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnGuardar.Enabled = false;
                this.btnActualizar.Enabled = true;
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
                Negocio.Garantia.Repuestoorden obj = new Negocio.Garantia.Repuestoorden();
                obj.PidOrdenTrabajo = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Repuestoorden_porNumero();

                if (dt.Rows.Count == 0)
                {
                    this.cboRepuesto.SelectedValue = 0;
                    this.txPrecioRepuesto.Text = "0";
                    this.txCantidadRepuesto.Text = "0";
                    this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                    
                }
                else
                {

                    this.cboRepuesto.SelectedValue = int.Parse(dt.Rows[0]["idRepuesto"].ToString());
                    this.txPrecioRepuesto.Text = (dt.Rows[0]["precioRepuestoOrden"].ToString());
                    this.txCantidadRepuesto.Text = (dt.Rows[0]["cantidadRepuestoOrden"].ToString());
                    this.lblNroOrden.Text = (dt.Rows[0]["idOrdenTrabajo"].ToString());
                   
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
                Negocio.Garantia.Repuestoorden obj = new Negocio.Garantia.Repuestoorden();
                obj.PidRepuestoOrden = 0;
                obj.PcantidadRepuestoOrden = int.Parse(this.txCantidadRepuesto.Text.Trim());
                obj.PprecioRepuestoOrden = decimal.Parse(this.txPrecioRepuesto.Text.Trim());
                obj.PfechaRepuesto = DateTime.Now;
                obj.PiConcurrenciaRepuestoOrden = 0;
                obj.PidRepuesto = long.Parse(this.cboRepuesto.SelectedValue.ToString());
                obj.PidOrdenTrabajo =long.Parse(this.lblNroOrden.Text);
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void lstBoxLista_Click(object sender, EventArgs e)
        {
            //this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Repuestoorden obj = new Negocio.Garantia.Repuestoorden();
                obj.PidRepuestoOrden = 0;
                obj.PcantidadRepuestoOrden = int.Parse(this.txCantidadRepuesto.Text.Trim());
                obj.PprecioRepuestoOrden = decimal.Parse(this.txPrecioRepuesto.Text.Trim());
                obj.PfechaRepuesto = DateTime.Now;
                obj.PiConcurrenciaRepuestoOrden = 0;
                obj.PidRepuesto = long.Parse(this.cboRepuesto.SelectedValue.ToString());
                obj.PidOrdenTrabajo = long.Parse(this.lblNroOrden.Text);
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
       

        private void txboxBuscar_Leave_1(object sender, EventArgs e)
        {
            if (this.txboxBuscar.Text.Trim().Equals(""))
            {
                this.txboxBuscar.Text = "Buscar";
            }
        }

        private void txboxBuscar_Enter(object sender, EventArgs e)
        {
            this.txboxBuscar.Text = "";
        }

        private void txboxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buscarOrdenes();
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

        private void txPrecioRepuesto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(this.txPrecioRepuesto.Text.Trim());
                int cantida = int.Parse(this.txCantidadRepuesto.Text.Trim());
                decimal total = precio * cantida;
                this.txPrecioTotalRepuesto.Text = total.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void txCantidadRepuesto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(this.txPrecioRepuesto.Text.Trim());
                int cantida = int.Parse(this.txCantidadRepuesto.Text.Trim());
                decimal total = precio * cantida;
                this.txPrecioTotalRepuesto.Text = total.ToString();
            }
            catch (Exception ex)
            {
                
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
