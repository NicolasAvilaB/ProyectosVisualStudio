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
    public partial class FrmRegistrarServicio : Form
    {
        public FrmRegistrarServicio()
        {
            InitializeComponent();
        }


        public void CargarServicios()
        {
            Negocio.Garantia.Servicio obj = new Negocio.Garantia.Servicio();
            this.cboServicio.DataSource = obj.Traer_Servicios();
            this.cboServicio.DisplayMember = "nombreServicio";
            this.cboServicio.ValueMember = "idServicio";
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
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistrarServicio_Load(object sender, EventArgs e)
        {
            try
            {
                CargarServicios();
                CargarOrdenesDeTrabajo();
                this.txboxBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            try
            {
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = false;

                this.CargarServicios();
                this.listServicios.Text = "";
                this.txPrecioServicio.Text = "";
                this.lblNroOrden.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txboxBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txboxBuscar.Text.Trim().Equals(""))
            {
                this.txboxBuscar.Text = "Buscar";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de este formulario?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {  
                //this.Limpiar();
                this.CargarServicios();
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarCampos();
                this.btnImprimir.Enabled = true;
                this.btnActualizar.Enabled = true;
                this.btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarCampos()
        {
            try
            {
                Negocio.Garantia.Serviciosorden obj = new Negocio.Garantia.Serviciosorden();
                obj.PidOrdenTrabajo = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Serviciosorden_porID();

                if (dt.Rows.Count == 0)
                {
                    this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                }
                else
                {
                    this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                    this.cboServicio.SelectedValue = int.Parse(dt.Rows[0]["idServicio"].ToString());
                    this.txPrecioServicio.Text = dt.Rows[0]["precioSevicio"].ToString();
                    this.listServicios.Text = dt.Rows[0]["objServicio"].ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Serviciosorden obj = new Negocio.Garantia.Serviciosorden();
                obj.PidServiciosOrden = 0;
                obj.PidServicio = long.Parse(this.cboServicio.SelectedValue.ToString());
                obj.PcantidadServicio = 1;
                obj.PfechaServicio = DateTime.Now;
                obj.PprecioSevicio = decimal.Parse(this.txPrecioServicio.Text.Trim());
                obj.PiConcurrenciaServicioOrden = 0;
                obj.PidOrdenTrabajo = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                obj.PobjServicio = this.listServicios.Text.Trim();
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Guardo Con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("***************************\nNo se pudo Guardar...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Serviciosorden obj = new Negocio.Garantia.Serviciosorden();
                obj.PidServiciosOrden = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                obj.PidServicio = long.Parse(this.cboServicio.SelectedValue.ToString());
                obj.PcantidadServicio = 1;
                obj.PfechaServicio = DateTime.Now;
                obj.PprecioSevicio = decimal.Parse(this.txPrecioServicio.Text.Trim());
                obj.PiConcurrenciaServicioOrden = 0;
                obj.PidOrdenTrabajo = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                obj.PobjServicio = this.listServicios.Text.Trim();
                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modifico Con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("***************************\nNo se pudo Modificar...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
