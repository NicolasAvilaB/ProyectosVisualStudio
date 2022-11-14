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
    public partial class frmRegistrarOrdenTrabajo : Form
    {
        public frmRegistrarOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void frmRegistrarOrdenTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
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
                this.Limpiar();
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.lstBoxLista.SetSelected(0, false);
            }
            catch (Exception ex)
            {
                
            }
        }


        public void Limpiar()
        {
            try
            {
                this.txNroOrden.Text = "";
                this.dtfechaOrdenTrabajo.Value = DateTime.Now;
                this.txEstadoOrden.Text = "RECEPCIONADO";
                this.txNroGarantiaOrden.Text = "";
                this.txSerieOrden.Text = "";
                this.txVendedorOrden.Text = "";
                this.txClienteOrden.Text = "";
                this.lstBoxProductoOrden.Text = "";
                txproblemacliente.Text = "";
                this.txNroGarantiaOrden.Focus();
                this.txEstadoOrden2.SelectedIndex = 0;
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

        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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
                Negocio.Garantia.Ordentrabajo obj = new Negocio.Garantia.Ordentrabajo();
                obj.PidOrdenTrabajo = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Ordtbl_trabajos_Completo();

                //zona orden de trabajo
                this.txNroOrden.Text = dt.Rows[0]["idOrdenTrabajo"].ToString();
                this.dtfechaOrdenTrabajo.Value = DateTime.Parse(dt.Rows[0]["fechaOrdenTrabajo"].ToString());

                //validar el estado de la orden
                if (int.Parse(dt.Rows[0]["estadoOrdenTrabajo"].ToString()) == 1)
                {
                    this.txEstadoOrden.Text = "RECEPCIONADO";
                }
                else
                {
                    this.txEstadoOrden.Text = "FINALIZADO";
                }

                //zona garantia
                this.txNroGarantiaOrden.Text = dt.Rows[0]["numeroGarantia"].ToString();
                this.txSerieOrden.Text = dt.Rows[0]["serieGarantia"].ToString();
                this.txVendedorOrden.Text = dt.Rows[0]["vendedor"].ToString();
                this.txClienteOrden.Text = dt.Rows[0]["cliente"].ToString();
                this.lstBoxProductoOrden.Text = dt.Rows[0]["nombreMarca"].ToString() + ", " + dt.Rows[0]["nombreLinea"].ToString() + "\n  " + dt.Rows[0]["nombreModelo"].ToString() + ", " + dt.Rows[0]["nombreProducto"].ToString();


                //validar el estado de la garantia
                string y = dt.Rows[0]["estadoGarantia"].ToString();

                if (int.Parse(dt.Rows[0]["estadoGarantia"].ToString()) == 1)
                {
                    this.txEstadoOrden2.SelectedIndex = 0;
                }
                else
                {
                    this.txEstadoOrden2.SelectedIndex = 1;
                }

                idGarantia = int.Parse(dt.Rows[0]["idGarantia"].ToString());
                this.txproblemacliente.Text = (dt.Rows[0]["descOrdenTrabajo"].ToString());
                btnImprimir.Enabled = true;  
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {
            
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

           

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

        private void txboxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buscarOrdenes();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txNroGarantiaOrden.Text.Trim() == "") || (this.txSerieOrden.Text.Trim() == "") || (this.txproblemacliente.Text.Trim() == ""))
                {
                    MessageBox.Show("Verifique los datos de Entrada", "Mensage de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((int.Parse(txNroGarantiaOrden.Text.Trim()) <= 0) || ((this.txSerieOrden.Text.Trim().Length) <= 0))
                    {
                        MessageBox.Show("No soporta valores negativos o menores a 1", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Negocio.Garantia.Ordentrabajo objTrabajo = new Negocio.Garantia.Ordentrabajo();
                        objTrabajo.PidOrdenTrabajo = int.Parse(this.txNroOrden.Text.Trim());
                        objTrabajo.PfechaOrdenTrabajo = this.dtfechaOrdenTrabajo.Value;
                        objTrabajo.PidGarantia = this.idGarantia;
                        if (txEstadoOrden.Text == "RECEPCIONADO")
                        {
                            objTrabajo.PestadoOrdenTrabajo = 1;
                        }
                        else
                        {
                            objTrabajo.PestadoOrdenTrabajo = 0;
                        }

                        objTrabajo.PidUsuario = 1;
                        objTrabajo.PiConcurrenciaOrdenTrabajo = 0;
                        objTrabajo.PdescOrdenTrabajo = this.txproblemacliente.Text.Trim();

                        if (objTrabajo.Modificar() == 1)
                        {
                            MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txNroGarantiaOrden.Text.Trim() == "") || (this.txSerieOrden.Text.Trim() == "") || (this.txproblemacliente.Text.Trim() == ""))
                {
                    MessageBox.Show("Verifique los datos de Entrada", "Mensage de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((int.Parse(txNroGarantiaOrden.Text.Trim()) <= 0) || ((this.txSerieOrden.Text.Trim().Length) <= 0))
                    {
                        MessageBox.Show("No soporta valores negativos o menores a 1", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Negocio.Garantia.Ordentrabajo objTrabajo = new Negocio.Garantia.Ordentrabajo();
                        objTrabajo.PidOrdenTrabajo = 0;
                        objTrabajo.PfechaOrdenTrabajo = this.dtfechaOrdenTrabajo.Value;
                        objTrabajo.PidGarantia = this.idGarantia;
                        if (txEstadoOrden.Text == "RECEPCIONADO")
                        {
                            objTrabajo.PestadoOrdenTrabajo = 1;
                        }
                        else
                        {
                            objTrabajo.PestadoOrdenTrabajo = 0;
                        }

                        objTrabajo.PidUsuario = 1;
                        objTrabajo.PiConcurrenciaOrdenTrabajo = 0;
                        objTrabajo.PdescOrdenTrabajo = this.txproblemacliente.Text.Trim();
                      
                        if (objTrabajo.Guardar() == 1)
                        {
                            MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.CargarOrdenesDeTrabajo();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void txNroGarantiaOrden_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    if (int.Parse(this.txNroGarantiaOrden.Text) <= 0)
                    {
                        MessageBox.Show("No soporta Valores Negativos o menores a 1", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (this.txNroGarantiaOrden.Text.Trim() == "")
                        {
                            MessageBox.Show("Verifique los datos de entrada..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            CargarGar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El numero de Garantia debe ser valido..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        int idGarantia = 0;
        public void CargarGar()
        {
            try
            {
                Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();

                if (this.txNroGarantiaOrden.Text.Trim().Equals(""))
                {
                    obj.PnumeroGarantia = 0;
                }
                else
                {
                    obj.PnumeroGarantia = long.Parse(this.txNroGarantiaOrden.Text);
                }

                if (this.txSerieOrden.Text.Trim().Equals(""))
                {
                    obj.PserieGarantia = "";
                }
                else
                {
                    obj.PserieGarantia = (this.txSerieOrden.Text);
                }
                
                DataTable dt = obj.Traer_Grtbl_garantias_x_numero();
                if (dt.Rows.Count == 0)
                {
                    Limpiar();
                }
                else
                {
                    if (dt.Rows[0]["nombreProducto"].ToString().Length == 0)
                    {
                        MessageBox.Show("La garantia no tiene producto Asignado: \n**************************\n\n Por lo tanto no podra ser Registrada la orden de Trabajo\n\n **************************", "SAT");
                        this.btnGuardar.Enabled = false;
                        this.btnActualizar.Enabled = false;
                    }
                    else
                    {
                        this.btnActualizar.Enabled = true;
                    }

                    this.txNroGarantiaOrden.Text = dt.Rows[0]["numeroGarantia"].ToString();
                    this.txSerieOrden.Text = dt.Rows[0]["serieGarantia"].ToString();
                    this.txVendedorOrden.Text = dt.Rows[0]["vendedor"].ToString();
                    this.txClienteOrden.Text = dt.Rows[0]["cliente"].ToString();
                    this.lstBoxProductoOrden.Text = dt.Rows[0]["nombreMarca"].ToString() + ", " + dt.Rows[0]["nombreLinea"].ToString() + "\n  " + dt.Rows[0]["nombremodelo"].ToString() + ", " + dt.Rows[0]["nombreProducto"].ToString();
                    this.idGarantia = int.Parse(dt.Rows[0]["idGarantia"].ToString());

                    if (int.Parse(dt.Rows[0]["estadoGarantia"].ToString()) == 1)
                    {
                        this.txEstadoOrden2.SelectedIndex = 0;
                    }
                    else
                    {
                        this.txEstadoOrden2.SelectedIndex = 1;
                    }
                    this.txproblemacliente.Text = "";
                    this.txproblemacliente.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }           
        }

        private void txSerieOrden_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    if (int.Parse(this.txSerieOrden.Text) <= 0)
                    {
                        MessageBox.Show("No porta valores Negativos..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txSerieOrden.Text.Trim() == "")
                        {
                            MessageBox.Show("Verifique los datos de entrada..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            CargarGar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos de entrada..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txPrecioRepuesto_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal precio = decimal.Parse(this.txPrecioRepuesto.Text);
            //    decimal cantidad = decimal.Parse(txCantidadRepuesto.Text);
            //    decimal total = precio * cantidad;
            //    txPrecioTotalRepuesto.Text = total.ToString();
            //}
            //catch (Exception ex)
            //{
 
            //}
        }

        private void txCantidadRepuesto_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal precio = decimal.Parse(this.txPrecioRepuesto.Text);
            //    decimal cantidad = decimal.Parse(txCantidadRepuesto.Text);
            //    decimal total = precio * cantidad;
            //    txPrecioTotalRepuesto.Text = total.ToString();
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void txNroGarantiaOrden_Enter(object sender, EventArgs e)
        {
            this.txSerieOrden.Text = "";
        }

        private void txSerieOrden_Enter(object sender, EventArgs e)
        {
            txNroGarantiaOrden.Text = "";
        }

        private void lstBoxLista_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }


    }
}
