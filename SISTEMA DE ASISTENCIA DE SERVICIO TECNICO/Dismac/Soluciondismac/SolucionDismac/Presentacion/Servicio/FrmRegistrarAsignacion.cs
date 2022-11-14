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
    public partial class FrmRegistrarAsignacion : Form
    {
        public FrmRegistrarAsignacion()
        {
            InitializeComponent();
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txboxBuscar_Leave(object sender, EventArgs e)
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

        public void Limpiar()
        {
            try
            {
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.CargarTecnicos();
                this.listTecnicos.Text = "";
                this.dtpFechaTecnico.Value = DateTime.Now;

                this.lblNroOrden.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        public void CargarTecnicos()
        {
            Negocio.Garantia.Tecnico obj = new Negocio.Garantia.Tecnico();
            this.cboTecnico.DataSource = obj.Traer_Tecnicos();
            this.cboTecnico.DisplayMember = "nombrePErsona";
            this.cboTecnico.ValueMember = "idTecnico";
        }

        private void FrmRegistrarAsignacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTecnicos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Asignacion obj = new Negocio.Garantia.Asignacion();
                obj.PidAsignacion = 0;
                obj.PfechaAsignacion = DateTime.Parse(this.dtpFechaTecnico.Value.ToString());
                obj.PobsAsignacion = this.listTecnicos.Text.Trim();
                obj.PiConcurrenciaAsignacion = 0;
                obj.PidOrdenTrabajo = int.Parse(this.lblNroOrden.Text);
                obj.PidTecnico = int.Parse(this.cboTecnico.SelectedValue.ToString());
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

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarCampos();
                btnImprimir.Enabled = true;
                this.btnActualizar.Enabled = true;
                this.btnGuardar.Enabled = false;
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
                Negocio.Garantia.Asignacion obj = new Negocio.Garantia.Asignacion();
                obj.PidOrdenTrabajo = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Asignacion_porNumero();

                if (dt.Rows.Count == 0)
                {
                    this.cboTecnico.SelectedValue = 0;
                    this.listTecnicos.Text = "";
                    this.dtpFechaTecnico.Value = DateTime.Now;
                    this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                    btnActualizar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
                else
                {

                    this.cboTecnico.SelectedValue = int.Parse(dt.Rows[0]["idTecnico"].ToString());
                    this.listTecnicos.Text = (dt.Rows[0]["obsAsignacion"].ToString());
                    this.dtpFechaTecnico.Text = (dt.Rows[0]["fechaAsignacion"].ToString());
                    
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Asignacion obj = new Negocio.Garantia.Asignacion();
                obj.PidAsignacion = 0;
                obj.PfechaAsignacion = DateTime.Parse(this.dtpFechaTecnico.Value.ToString());
                obj.PobsAsignacion = this.listTecnicos.Text.Trim();
                obj.PiConcurrenciaAsignacion = 0;
                obj.PidOrdenTrabajo = int.Parse(this.lblNroOrden.Text);
                obj.PidTecnico = int.Parse(this.cboTecnico.SelectedValue.ToString());
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnActualizar.Enabled = false;
            this.btnGuardar.Enabled = true;
        }

    }
}
