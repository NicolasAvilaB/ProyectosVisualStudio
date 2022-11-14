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
    public partial class FrmDetalleOrdendeTrabajo : Form
    {
        public FrmDetalleOrdendeTrabajo()
        {
            InitializeComponent();
        }

        private void FrmDetalleOrdendeTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarOrdenesDeTrabajo();
                CargarDesperfectos();
                CargarTecnicos();
                CargarRepuestos();
                CargarServicios();
                this.txboxBuscar.Focus();

                             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }



        public void CargarServicios()
        {
            try
            {
                Negocio.Garantia.Ordtbl_pservicios obj = new Negocio.Garantia.Ordtbl_pservicios();
                this.cboServicio.DataSource = obj.Traer_Servicios();
                this.cboServicio.DisplayMember = "sServicio_nm";
                this.cboServicio.ValueMember = "iServicio_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        public void CargarRepuestos()
        {
            try
            {
                Negocio.Garantia.Ordtbl_prepuesto obj = new Negocio.Garantia.Ordtbl_prepuesto();
                this.cboRepuesto.DataSource = obj.Traer_Ordtbl_prepuesto();
                this.cboRepuesto.DisplayMember = "sRepuesto_nm";
                this.cboRepuesto.ValueMember = "iRepuesto_id";
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
                Negocio.Garantia.Ordtbl_pdesperfectos obj = new Negocio.Garantia.Ordtbl_pdesperfectos();
                this.cboDesperfectoInforme.DataSource = obj.Traer_Desperfecto_Parametrizado();
                this.cboDesperfectoInforme.DisplayMember = "sDesperfecto_nm";
                this.cboDesperfectoInforme.ValueMember = "iDespefecto_id"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        public void CargarTecnicos()
        {
            try
            {
                Negocio.Garantia.Pertbl_tecnicos obj = new Negocio.Garantia.Pertbl_tecnicos();
                this.cboTecnico.DataSource = obj.Traer_Pertbl_tecnicos();
                this.cboTecnico.DisplayMember = "sPFisica_nm";
                this.cboTecnico.ValueMember = "lTecnico_id";
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
                Negocio.Garantia.Ordtbl_trabajos obj = new Negocio.Garantia.Ordtbl_trabajos();
                this.lstBoxLista.DataSource = obj.Traer_Ordtbl_trabajos_con_Nombre();
                this.lstBoxLista.DisplayMember = "nombreCliente";
                this.lstBoxLista.ValueMember = "lTrabajo_id";
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
                if (txboxBuscar.Text.Trim() == "")
                {
                    MessageBox.Show("Verifique los datos de entrada..", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.Parse(txboxBuscar.Text.Trim()) <= 0)
                    {
                        MessageBox.Show("No soporta valores negativos o menores a 1", "Mensage de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                    {
                        buscarOrdenes();
                    }

                }
            }
        }

        public void buscarOrdenes()
        {
            //si selecciono gestion

            if (this.cboGestion.SelectedIndex == 0)
            {
                //this.lstBoxLista.Items.Clear();
                try
                {
                    Negocio.Garantia.Ordtbl_trabajos obj = new Negocio.Garantia.Ordtbl_trabajos();
                    obj.PdtTrabajo_dt = DateTime.Parse(this.txboxBuscar.Text.Trim() + "-01-01");
                    //buscar por año

                    this.lstBoxLista.DataSource = obj.Traer_trabajos_año();
                    this.lstBoxLista.DisplayMember = "nombreCliente";
                    this.lstBoxLista.ValueMember = "lTrabajo_id";

                    if (obj.Traer_trabajos_año().Rows.Count == 0)
                    {
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Tipo:\n" + ex.Message);
                }

            }
            //si selecciono buscar por nro
            else
            {
                //this.lstBoxLista.Items.Clear();
                try
                {
                    Negocio.Garantia.Ordtbl_trabajos obj = new Negocio.Garantia.Ordtbl_trabajos();
                    obj.PlTrabajo_id = int.Parse(this.txboxBuscar.Text.Trim());

                    //buscar por numero de Orden
                    obj.PlTrabajo_id = int.Parse(this.txboxBuscar.Text.Trim());
                    //buscar por año
                    this.lstBoxLista.DataSource = obj.Traer_trabajos_nro();
                    this.lstBoxLista.DisplayMember = "nombreCliente";
                    this.lstBoxLista.ValueMember = "lTrabajo_id";

                    if (obj.Traer_trabajos_nro().Rows.Count == 0)
                    {
                        Limpiar();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Tipo:\n" + ex.Message);
                }

            }
        }


        public void Limpiar()
        {
            try
            {
                //limpiar tab asignacion
                this.lblNroOrden.Text = "";
                this.dtpFechaTecnico.Value = DateTime.Now;
                this.listTecnicos.Text = "";
                this.CargarTecnicos();


                listDesperfectos.Text = "";
                txPrecioRepuesto.Text = "";
                txCantidadRepuesto.Text = "";
                txPrecioTotalRepuesto.Text = "";
                txPrecioServicio.Text = "";
                listServicios.Text = "";
                listFinal.Text = "";

                dtpFechaTecnico.Value = DateTime.Now;
                dtpFechaInforme.Value = DateTime.Now;
                dtFechaInformeFinal.Value = DateTime.Now;

                //this.txNroGarantiaOrden.Focus();
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
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

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarCampos();
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = true;
                btnImprimir.Enabled = true;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }




         


       
        public void CargarAsignacion()
        {
            try
            {
                Negocio.Garantia.Ordtbl_trabajos obj = new Negocio.Garantia.Ordtbl_trabajos();
                obj.PlTrabajo_id = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Asignacion_por_nro();
               
                if (dt.Rows.Count == 0)
                {
                    btnActualizar.Enabled = false;
                    tabControl1.TabPages.Remove(tabPage2);
                }
                else
                {
                    btnActualizar.Enabled = true;
                    tabControl1.TabPages.Add(tabPage2);
                }

                ////tab Asignacion
                this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                this.cboTecnico.SelectedValue = int.Parse(dt.Rows[0]["lTecnico_id"].ToString());
                this.dtpFechaTecnico.Value = DateTime.Parse(dt.Rows[0]["dtAsignacion_dt"].ToString());
                this.listTecnicos.Text = dt.Rows[0]["sObservacion_desc"].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }



        
        public void CargarInforme()
        {
            try
            {
                Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                obj.PlTrabajo_id = int.Parse(this.lstBoxLista.SelectedValue.ToString());

                DataTable dt = obj.Traer_Ordtbl_informes();
                
                if (dt.Rows.Count == 0)
                {
                    btnActualizar.Enabled = false;
                    tabControl1.TabPages.Remove(tabPage3);
                }
                else
                {
                    btnActualizar.Enabled = true;
                    tabControl1.TabPages.Add(tabPage3);
                }

                ////tab Informe
                this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                this.cboDesperfectoInforme.SelectedValue = int.Parse(dt.Rows[0]["iDespefecto_id"].ToString());
                this.listDesperfectos.Text = dt.Rows[0]["sObservacion_desc"].ToString();
                this.dtpFechaInforme.Value = DateTime.Parse(dt.Rows[0]["dtInforme_dt"].ToString());


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }



        int cantidadFinal = 0;
        public void CargarInforme2()
        {
            try
            {
                Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                obj.PlTrabajo_id = int.Parse(this.lstBoxLista.SelectedValue.ToString());
               
                DataTable dt = obj.Traer_Ordtbl_informes();

                if (dt.Rows.Count == 0)
                {
                    tabControl1.TabPages.Add(tabPage5);
                }
                else
                {
                    tabControl1.TabPages.Add(tabPage5);
                }
                cantidadFinal = dt.Rows.Count;

                ////tab Informe
                this.lblNroOrden.Text = this.lstBoxLista.SelectedValue.ToString();
                this.listFinal.Text = dt.Rows[0]["sObservacion_desc"].ToString();
                this.dtFechaInformeFinal.Value = DateTime.Parse(dt.Rows[0]["dtInforme_dt"].ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }



       
        public void CargarServicio()
        {
            try
            {
                //tab servicios

                Negocio.Garantia.Ordtbl_servicios obj = new Negocio.Garantia.Ordtbl_servicios();
                obj.PlTrabajo_id = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Ordtbl_servicios_por_numero();

                if (dt.Rows.Count == 0)
                {
                    tabControl1.TabPages.Add(tabPage6);
                }
                else
                {
                    tabControl1.TabPages.Add(tabPage6);
                }
                this.cboServicio.SelectedValue = dt.Rows[0]["iServicio_id"].ToString();
                this.txPrecioServicio.Text = dt.Rows[0]["cServicio_amt"].ToString();
                this.listServicios.Text = dt.Rows[0]["sObservacion_desc"].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }




        
        public void CargarRepuesto()
        {
            try
            {
                //tab respuesto

                Negocio.Garantia.Ordtbl_repuestos obj = new Negocio.Garantia.Ordtbl_repuestos();
                obj.PlTrabajo_id = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Ordtbl_repuestos_por_Nro();

                if (dt.Rows.Count == 0)
                {
                    tabControl1.TabPages.Add(tabPage4);
                }
                else
                {
                    tabControl1.TabPages.Add(tabPage4);
                }

                int x = int.Parse(dt.Rows[0]["lRepuesto_id"].ToString());
                if (x == 0)
                {
                    this.cboRepuesto.SelectedValue = 0;
                    this.txPrecioRepuesto.Text = "0";
                    this.txCantidadRepuesto.Text = "0";
                    this.txPrecioTotalRepuesto.Text = "0";
                }
                else
                {
                    this.cboRepuesto.SelectedValue = int.Parse(dt.Rows[0]["lRepuesto_id"].ToString());
                    this.txPrecioRepuesto.Text = (dt.Rows[0]["cRepuesto_amt"].ToString());
                    this.txCantidadRepuesto.Text = (dt.Rows[0]["iRepuesto_qty"].ToString());
                    float precioTotal = float.Parse(dt.Rows[0]["iRepuesto_qty"].ToString()) * float.Parse(dt.Rows[0]["cRepuesto_amt"].ToString());
                    this.txPrecioTotalRepuesto.Text = precioTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }



        
        public void llenarCampos()
        {
            try
            {
                this.CargarAsignacion();
                this.CargarInforme();
                this.CargarInforme2();
                this.CargarServicio();
                this.CargarRepuesto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
                //this.lstBoxLista.SetSelected(0, false);
                this.Limpiar();
            }
            catch (Exception ex)
            {

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


        int actual = 0, anterior = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.tabControl1.SelectedIndex == 0)
                {
                    this.CargarAsignacion();
                }

                if (this.tabControl1.SelectedIndex == 1)
                {
                    this.CargarInforme();
                }

                if (this.tabControl1.SelectedIndex == 2)
                {
                    this.CargarRepuesto();
                }


                if (this.tabControl1.SelectedIndex == 3)
                {
                    this.CargarServicio();
                }

                if (this.tabControl1.SelectedIndex == 4)
                {
                    this.CargarInforme2();
                }


                actual = tabControl1.SelectedIndex;
                if (this.btnActualizar.Enabled==true && (actual == anterior + 1 || actual == anterior - 1))
                {
                    llenarCampos();
                    if (lstBoxLista.Items.Count < 1)//17.05.2012
                    {
                        
                    }
                    anterior = actual;
                }
                else
                    tabControl1.SelectedIndex = anterior;

            }
            catch (Exception ex)
            {
 
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                //
                if (this.tabControl1.SelectedIndex == 0)
                {
                    Negocio.Garantia.Ordtbl_asignaciones obj = new Negocio.Garantia.Ordtbl_asignaciones();
                    obj.PlAsignacion_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PlTecnico_id = int.Parse(this.cboTecnico.SelectedValue.ToString());
                    obj.PdtAsignacion_dt = DateTime.Parse(this.dtpFechaTecnico.Value.ToString());
                    obj.PsObservacion_desc = this.listTecnicos.Text;
                    obj.PdtRegistro_dt = DateTime.Now;
                    obj.PiConcurrencia_id = 0;
                    if (obj.Guardar() == 1)
                    {
                        MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                //guardar informe
                if (this.tabControl1.SelectedIndex == 1)
                {
                    Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                    obj.PlInforme_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PdtInforme_dt = DateTime.Parse(dtpFechaInforme.Value.ToString());
                    obj.PsObservacion_desc = this.listDesperfectos.Text;
                    obj.PiInforme_fl = 0;
                    obj.PiDespefecto_id = short.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                    if (obj.Guardar() == 1)
                    {
                        MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }




                //guardar Repuesto
                if (this.tabControl1.SelectedIndex == 2)
                {
                    Negocio.Garantia.Ordtbl_repuestos obj = new Negocio.Garantia.Ordtbl_repuestos();
                    obj.PlRepuesto_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PiProducto_id = 4;
                    obj.PiRepuesto_qty = int.Parse(this.txCantidadRepuesto.Text);
                    obj.PcRepuesto_amt = decimal.Parse(this.txPrecioRepuesto.Text);
                    obj.PdtRepuesto_dt = DateTime.Now;
                    obj.PiConcurrencia_id = 0;
                    if (obj.Guardar() == 1)
                    {
                        MessageBox.Show("Se Guardar con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                //guardar Servicio
                if (this.tabControl1.SelectedIndex == 3)
                {
                    Negocio.Garantia.Ordtbl_servicios obj = new Negocio.Garantia.Ordtbl_servicios();

                    obj.PiServicio_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PsObservacion_desc = this.listServicios.Text;
                    obj.PiServicio_id = short.Parse(this.cboServicio.SelectedValue.ToString());
                    obj.PiServicio_qty = 1;
                    obj.PcServicio_amt = decimal.Parse(this.txPrecioServicio.Text);
                    obj.PdtServicio_dt = DateTime.Now; 
                    obj.PiConcurrencia_id = 0;
                    if (obj.Guardar() == 1)
                    {
                        MessageBox.Show("Se Guardar con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                //guardar Final
                if (this.tabControl1.SelectedIndex == 4)
                {
                    Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                    obj.PlInforme_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PdtInforme_dt = DateTime.Parse(this.dtFechaInformeFinal.Value.ToString());
                    obj.PsObservacion_desc = this.listFinal.Text;
                    obj.PiInforme_fl = 0;
                    obj.PiDespefecto_id = short.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                if (this.tabControl1.SelectedIndex == 0)
                {
                    Negocio.Garantia.Ordtbl_asignaciones obj = new Negocio.Garantia.Ordtbl_asignaciones();
                    obj.PlAsignacion_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PlTecnico_id = int.Parse(this.cboTecnico.SelectedValue.ToString());
                    obj.PdtAsignacion_dt = DateTime.Parse(this.dtpFechaTecnico.Value.ToString());
                    obj.PsObservacion_desc = this.listTecnicos.Text;
                    obj.PdtRegistro_dt = DateTime.Now;
                    obj.PiConcurrencia_id = 0;
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                //guardar informe
                if (this.tabControl1.SelectedIndex == 1)
                {
                    Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                    obj.PlInforme_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PdtInforme_dt = DateTime.Parse(dtpFechaInforme.Value.ToString());
                    obj.PsObservacion_desc = this.listDesperfectos.Text;
                    obj.PiInforme_fl = 0;
                    obj.PiDespefecto_id = short.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


                //guardar Repuesto
                if (this.tabControl1.SelectedIndex == 2)
                {
                    Negocio.Garantia.Ordtbl_repuestos obj = new Negocio.Garantia.Ordtbl_repuestos();
                    obj.PlRepuesto_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PiProducto_id = 4;
                    obj.PiRepuesto_qty = int.Parse(this.txCantidadRepuesto.Text);
                    obj.PcRepuesto_amt = decimal.Parse(this.txPrecioRepuesto.Text);
                    obj.PdtRepuesto_dt = DateTime.Now;
                    obj.PiConcurrencia_id = 0;
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se Modifico con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



                //modificar Servicio
                if (this.tabControl1.SelectedIndex == 3)
                {
                    Negocio.Garantia.Ordtbl_servicios obj = new Negocio.Garantia.Ordtbl_servicios();

                    obj.PiServicio_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PsObservacion_desc = this.listServicios.Text;
                    obj.PiServicio_id = short.Parse(this.cboServicio.SelectedValue.ToString());
                    obj.PiServicio_qty = 1;
                    obj.PcServicio_amt = decimal.Parse(this.txPrecioServicio.Text);
                    obj.PdtServicio_dt = DateTime.Now;
                    obj.PiConcurrencia_id = 0;
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se Modificar con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                //guardar Final
                if (this.tabControl1.SelectedIndex == 4)
                {
                    Negocio.Garantia.Ordtbl_informes obj = new Negocio.Garantia.Ordtbl_informes();
                    obj.PlInforme_id = 0;
                    obj.PlTrabajo_id = int.Parse(this.lblNroOrden.Text);
                    obj.PdtInforme_dt = DateTime.Parse(this.dtFechaInformeFinal.Value.ToString());
                    obj.PsObservacion_desc = this.listFinal.Text;
                    obj.PiInforme_fl = 0;
                    obj.PiDespefecto_id = short.Parse(this.cboDesperfectoInforme.SelectedValue.ToString());
                    if (obj.Modificar() == 1)
                    {
                        MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                decimal precio = decimal.Parse(this.txPrecioRepuesto.Text);
                decimal cantidad = decimal.Parse(txCantidadRepuesto.Text);
                decimal total = precio * cantidad;
                txPrecioTotalRepuesto.Text = total.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txCantidadRepuesto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(this.txPrecioRepuesto.Text);
                decimal cantidad = decimal.Parse(txCantidadRepuesto.Text);
                decimal total = precio * cantidad;
                txPrecioTotalRepuesto.Text = total.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Utilitario.Utilitario.nroOrdenTrabajo = int.Parse(this.lblNroOrden.Text);
                Utilitario.Utilitario.listadoReporte = 1;
                FrmReporte fr = new FrmReporte();
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de tipo\n" + ex.Message);
            }
        }



    }
    
}
