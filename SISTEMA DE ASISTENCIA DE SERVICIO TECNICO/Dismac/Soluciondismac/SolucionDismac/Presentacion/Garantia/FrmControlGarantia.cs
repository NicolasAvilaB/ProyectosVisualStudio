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
    public partial class FrmControlGarantia : Form
    {
        public FrmControlGarantia()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }


        public void CargarCliente()
        {
            Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
            this.comboBox1.DataSource = obj.Traer_Cliente();
            this.comboBox1.DisplayMember = "nombrePersona";
            this.comboBox1.ValueMember = "idPersona";
        }
        public void CargarVendedor()
        {
            Negocio.Garantia.Vendedor obj = new Negocio.Garantia.Vendedor();
            this.comboBox2.DataSource = obj.Traer_Vendedor();
            this.comboBox2.DisplayMember = "nombrePersona";
            this.comboBox2.ValueMember = "idPersona";
        }


        public void CargarControles()
        {
            try
            {
                Negocio.Garantia.Control obj = new Negocio.Garantia.Control();
                obj.PdescControl = "";
                this.lstBoxLista.DataSource = obj.Traer_Controles();
                this.lstBoxLista.DisplayMember = "nombreControl";
                this.lstBoxLista.ValueMember = "idControl";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }

        private void FrmControlGarantia_Load(object sender, EventArgs e)
        {
            try
            {
                CargarVendedor();
                CargarCliente();
                CargarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Rows.Clear();
                GenerarGarantias();
                CargarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }

        }

        int cl = 0;





        int dif = 0;
        int ini = 0;
        int fin = 0;

        public bool valdiar()
        {
            bool resp = false;
            ini = int.Parse(this.textBox1.Text);
            fin = int.Parse(this.textBox2.Text);

            if (fin >= ini)
            {
                resp = true;
                dif = fin - ini;
            }
            else
            {
                resp = false;
            }
            return resp;
        }

        public void GenerarGarantias()
        {
            cl = cl + 1;
            try
            {
                if (valdiar())
                {
                    this.btnGuardar.Enabled = true;
                    if (cl == 1)
                    {
                        this.dataGridView1.Columns.Add("ID", "ID");
                        this.dataGridView1.Columns.Add("numeroGaratia", " Nro Garantia");
                        this.dataGridView1.Columns.Add("serieGarantia", "Nro Serie");
                        this.dataGridView1.Columns.Add("fechaCompra", "Fecha Compra");
                        this.dataGridView1.Columns.Add("fechaValidezGarantia", "Fecha Validez");
                        this.dataGridView1.Columns.Add("cliente", "Cliente");
                        this.dataGridView1.Columns.Add("Vendedor", "Vendedor");
                        this.dataGridView1.Columns.Add("idCliente", "idCliente");
                        this.dataGridView1.Columns.Add("idVendendor", "idVendedor");

                        //this.dataGridView2.Columns.Add("idPrestamo", "Prestamo");
                    }
                    int x = 0;
                    for (int i = ini; i <= fin ; i++)
                    {
                        x++;
                        this.dataGridView1.Rows.Add(x, i , "ser-" + ini + i, DateTime.Now, DateTime.Now, this.comboBox1.Text, this.comboBox2.Text,this.comboBox1.SelectedValue,this.comboBox2.SelectedValue);
                    }
                    this.dataGridView1.Columns[7].Visible = false;
                    this.dataGridView1.Columns[8].Visible = false;
                }
                else
                {
                    MessageBox.Show("el numero Inicial debe ser menor a el numero Final");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.dataGridView1.Rows.Clear();
            this.CargarCliente();
            this.CargarVendedor();
            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
            this.textBox1.Focus();
        }



        public void Imprimir()
        {
            try
            {
                Utilitario.Utilitario.Inicial = int.Parse(this.textBox1.Text.Trim());
                Utilitario.Utilitario.Final = int.Parse(this.textBox2.Text.Trim());
                Utilitario.Utilitario.listadoReporte = 1;
                FrmReporte fr = new FrmReporte();
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de tipo\n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
                Utilitario.Utilitario.Inicial = int.Parse(this.textBox1.Text.Trim());
                Utilitario.Utilitario.Final = int.Parse(this.textBox2.Text.Trim());
                DataTable dt = obj.Validar_Garantia();
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("***************************\nya Existen garantias dentro del Rango seleccionado...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resul;
                    resul = MessageBox.Show("Esta seguro que desea Generar el siguiente rango de  Garantias ?\n Del: " + ini + " Al: " + fin, "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resul == DialogResult.OK)
                    {
                        if (this.dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("***************************\nNo se generaron Garantias...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Negocio.Garantia.Garantia obj2 = new Negocio.Garantia.Garantia();
                            obj2.PidGarantia = 0;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                obj2.PnumeroGarantia = int.Parse(row.Cells[1].Value.ToString());
                                obj2.PserieGarantia = row.Cells[2].Value.ToString();
                                obj2.PfechaCompra = DateTime.Parse(row.Cells[3].Value.ToString());
                                obj2.PfechaValidezGarantia = DateTime.Parse(row.Cells[4].Value.ToString());
                                obj2.PiConcurrenciaGarantia = 0;
                                obj2.PobsGarantia = "garantia a mayorista";
                                obj2.PfechaValidezGarantia = DateTime.Parse(row.Cells[4].Value.ToString());
                                obj2.PestadoGarantia = 1;
                                obj2.PidProducto = 0;
                                obj2.PidCliente = int.Parse(row.Cells[7].Value.ToString());
                                obj2.PidVendedor = long.Parse(row.Cells[8].Value.ToString());
                                if (obj2.Guardar() == 1)
                                {
                                    CargarControles();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                if (guardarControl())
                {
                    MessageBox.Show("Se guardo con Exito..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar..", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Imprimir();
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
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            Limpiar();
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
                Negocio.Garantia.Control obj = new Negocio.Garantia.Control();
                obj.PdescControl = this.txboxBuscar.Text.Trim();
                this.lstBoxLista.DataSource = obj.Traer_Controles();
                this.lstBoxLista.DisplayMember = "nombreControl";
                this.lstBoxLista.ValueMember = "idControl";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }


        public bool modificarControl()
        {
            bool resp = false;
            Negocio.Garantia.Control obj = new Negocio.Garantia.Control();
            obj.PidControl = long.Parse(this.lstBoxLista.SelectedValue.ToString());
            obj.PfechaControl = DateTime.Now;
            obj.PnumeroInicialGarantia = int.Parse(this.textBox1.Text);
            obj.PnumeroFinalGarantia = int.Parse(this.textBox2.Text);
            obj.PdescControl = "";
            obj.PiConcurrenciaControl = 0;
            obj.PidCliente = long.Parse(this.comboBox1.SelectedValue.ToString());
            obj.PidVendedor = long.Parse(this.comboBox2.SelectedValue.ToString());
            if (obj.Modificar() == 1)
            {
                MessageBox.Show("Se modifico con Exito...", "SAT informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resp = true;
            }
            else
            {
                MessageBox.Show("No se pudo Modificar...", "SAT informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resp = false;
            }
            return resp;
        }




        public bool guardarControl()
        {
            bool resp = false;
            Negocio.Garantia.Control obj = new Negocio.Garantia.Control();
            obj.PidControl = 0;
            obj.PfechaControl = DateTime.Now;
            obj.PnumeroInicialGarantia = int.Parse(this.textBox1.Text);
            obj.PnumeroFinalGarantia = int.Parse(this.textBox2.Text);
            obj.PdescControl = "";
            obj.PiConcurrenciaControl = 0;
            obj.PidCliente = long.Parse(this.comboBox1.SelectedValue.ToString());
            obj.PidVendedor = long.Parse(this.comboBox2.SelectedValue.ToString());
            if (obj.Guardar() == 1)
            {
                resp = true;
            }
            else
            {
                resp = false;
            }
            return resp;
        }


       
        public void LlenarCampos()
        {
            try
            {
                Negocio.Garantia.Control obj = new Negocio.Garantia.Control();
                obj.PidControl = int.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Control_porNumero();
                if (dt.Rows.Count == 0)
                {
                    
                }
                else
                {
                    this.comboBox1.SelectedValue = dt.Rows[0]["idCliente"].ToString();
                    this.comboBox2.SelectedValue = dt.Rows[0]["idVendedor"].ToString();
                    this.textBox1.Text = dt.Rows[0]["numeroInicialGarantia"].ToString();
                    this.textBox2.Text = dt.Rows[0]["numeroFinalGarantia"].ToString();
                    this.textBox3.Text = dt.Rows[0]["idControl"].ToString();
                    this.textBox4.Text = dt.Rows[0]["idControl"].ToString();
                    this.dateTimePicker1.Value = DateTime.Parse(dt.Rows[0]["fechaControl"].ToString());
                    this.dateTimePicker2.Value = DateTime.Parse(dt.Rows[0]["fechaControl"].ToString());
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                modificarControl();
                CargarControles();
                Imprimir();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void lstBoxLista_Click(object sender, EventArgs e)
        {
            this.btnActualizar.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.dataGridView1.Rows.Clear();
            try
            {
                LlenarCampos();
                GenerarGarantias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox5.Text = this.comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.comboBox2.Text;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
