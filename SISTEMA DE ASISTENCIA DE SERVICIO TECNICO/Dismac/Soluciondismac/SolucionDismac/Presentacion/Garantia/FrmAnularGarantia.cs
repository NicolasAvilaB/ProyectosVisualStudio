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
    public partial class FrmAnularGarantia : Form
    {
        public FrmAnularGarantia()
        {
            InitializeComponent();
        }


        public void CargarMayorista()
        {
            Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
            this.cbomayorista.DataSource = obj.Traer_Cliente();
            this.cbomayorista.DisplayMember = "nombrePersona";
            this.cbomayorista.ValueMember = "idPersona";
        }

        public void CargarVendedor()
        {
            Negocio.Garantia.Vendedor obj = new Negocio.Garantia.Vendedor();
            this.cbovendedor.DataSource = obj.Traer_Vendedor();
            this.cbovendedor.DisplayMember = "nombrePersona";
            this.cbovendedor.ValueMember = "idPersona";
        }

        public void CargarGarantias()
        {
            Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
            obj.PobsGarantia = "";

            this.lstBoxLista.DataSource = obj.Traer_Garantias_comodin();
            this.lstBoxLista.DisplayMember = "nombrePersona";
            this.lstBoxLista.ValueMember = "idGarantia";
        }


        public void CargarMarca()
        {
            Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
            this.cboMarca.DataSource = obj.Traer_Marca();
            this.cboMarca.DisplayMember = "nombreMarca";
            this.cboMarca.ValueMember = "idMarca";
        }

        private void FrmAnularGarantia_Load(object sender, EventArgs e)
        {
            try
            {
                txtnroGarantia.Focus();
                CargarVendedor();
                CargarMayorista();
                CargarMarca();
                CargarGarantias();
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
                Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
                obj.PobsGarantia = this.txboxBuscar.Text.Trim();
                this.lstBoxLista.DataSource = obj.Traer_Garantias_comodin();
                this.lstBoxLista.DisplayMember = "nombrePersona";
                this.lstBoxLista.ValueMember = "idGarantia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCampos();
        }


        public void LlenarCampos()
        {
            try
            {
                Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
                obj.PidGarantia = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Garantias_por_idGarantia();
                if (dt.Rows.Count == 0)
                {
                }
                else
                {
                    this.txtcodigo1.Text = dt.Rows[0]["idGarantia"].ToString();
                    this.txtcodigo2.Text = dt.Rows[0]["idGarantia"].ToString();
                    this.dtfecha1.Value = DateTime.Parse(dt.Rows[0]["fechaCompra"].ToString());
                    this.dtfecha2.Value = DateTime.Parse(dt.Rows[0]["fechaCompra"].ToString());

                    this.cbomayorista.SelectedValue = int.Parse(dt.Rows[0]["idCliente"].ToString());
                    this.cbovendedor.SelectedValue = int.Parse(dt.Rows[0]["idVendedor"].ToString());

                    this.txtnroGarantia.Text = dt.Rows[0]["numeroGarantia"].ToString();
                    this.txtSerieProducto.Text = dt.Rows[0]["serieGarantia"].ToString();

                    this.dtFechaFin.Value = DateTime.Parse(dt.Rows[0]["fechaCompra"].ToString());
                    this.dtFechaFin.Value = DateTime.Parse(dt.Rows[0]["fechaValidezGarantia"].ToString());

                    this.cboMarca.SelectedValue = int.Parse(dt.Rows[0]["idMarca"].ToString());
                    this.cboLinea.SelectedValue = int.Parse(dt.Rows[0]["idLinea"].ToString());
                    this.cboModelo.SelectedValue = int.Parse(dt.Rows[0]["idModelo"].ToString());
                    this.cboProducto.SelectedValue = int.Parse(dt.Rows[0]["idProducto"].ToString());

                    this.txtObservacionGarantia.Text = dt.Rows[0]["obsGarantia"].ToString();

                    if (int.Parse(dt.Rows[0]["estadoGarantia"].ToString()) == 1)
                    {
                        this.rdbValido.Checked = true;
                    }
                    else
                    {
                        this.Anulada.Checked = true;
                    }
                }
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
                this.btnImprimir.Enabled = true;
                Utilitario.Utilitario.idGarantiaReporte = int.Parse(this.txtcodigo1.Text.Trim());
                Utilitario.Utilitario.listadoReporte = 2;
                FrmReporte fr = new FrmReporte();
                fr.Show();
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
                Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
                obj.PidGarantia = int.Parse(this.txtcodigo1.Text);
                obj.PnumeroGarantia = long.Parse(this.txtnroGarantia.Text);
                obj.PserieGarantia = this.txtSerieProducto.Text;
                obj.PfechaCompra = DateTime.Parse(this.dtFechaInicio.Value.ToString());
                obj.PfechaValidezGarantia = DateTime.Parse(this.dtFechaFin.Value.ToString());
                obj.PobsGarantia = this.txtObservacionGarantia.Text;
                if (this.rdbValido.Checked == true)
                {
                    obj.PestadoGarantia = 1;
                }
                else
                {
                    obj.PestadoGarantia = 0;
                }
                obj.PiConcurrenciaGarantia = 0;
                obj.PidCliente = long.Parse(this.cbomayorista.SelectedValue.ToString());
                obj.PidVendedor = long.Parse(this.cbovendedor.SelectedValue.ToString());
                if (this.cboProducto.SelectedValue == null)
                {
                    obj.PidProducto = 0;
                }
                else
                {
                    obj.PidProducto = long.Parse(this.cboProducto.SelectedValue.ToString()); 
                }

                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("***************************\nSE ANULO LA GARANTIA CON EXITO...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("***************************\nNO SE PUDO ANULAR LA GARANTIA...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbovendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVendedor.Text = this.cbovendedor.Text;
        }

        private void cbomayorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCliente.Text = cbomayorista.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    
    }
}
