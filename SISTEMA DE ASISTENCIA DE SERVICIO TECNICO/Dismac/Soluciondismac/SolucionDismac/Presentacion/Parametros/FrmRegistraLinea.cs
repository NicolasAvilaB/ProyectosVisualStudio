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
    public partial class FrmRegistraLinea : Form
    {
        public FrmRegistraLinea()
        {
            InitializeComponent();
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
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PdescLinea = this.txboxBuscar.Text;
                this.lstBoxLista.DataSource = obj.Traer_Linea_Comodin();
                this.lstBoxLista.DisplayMember = "nombreLineas";
                this.lstBoxLista.ValueMember = "idLinea";
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

        public void CargarMarcas()
        {
            try
            {
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PidMarca = 0;
                this.comboBox1.DataSource = obj.Traer_Marca();
                this.comboBox1.DisplayMember = "nombreMarca";
                this.comboBox1.ValueMember = "idMarca";
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void CargarListaLinea()
        {
            try
            {
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PdescLinea = "";
                this.lstBoxLista.DataSource = obj.Traer_Linea_Comodin();
                this.lstBoxLista.DisplayMember="nombreLineas";
                this.lstBoxLista.ValueMember = "idLinea";
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistraLinea_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMarcas();
                CargarListaLinea();
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txboxBuscar_TextChanged(object sender, EventArgs e)
        {

        }


        public void LlenarCampos()
        {
            try
            {
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PidLinea = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Linea_porID();
                if (dt.Rows.Count == 0)
                {

                }
                else
                {
                    this.textBox1.Text = dt.Rows[0]["idLinea"].ToString();
                    this.textBox2.Text = dt.Rows[0]["nombreLinea"].ToString();
                    this.textBox3.Text = dt.Rows[0]["descLinea"].ToString();
                    this.comboBox1.SelectedValue = int.Parse(dt.Rows[0]["idMarca"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarCampos();
                this.btnActualizar.Enabled = true;
                this.btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
 
            }
        }



        public void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.CargarMarcas();
            this.textBox2.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnActualizar.Enabled = false;
            this.btnGuardar.Enabled = true;
            Limpiar();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PidLinea = 0;
                obj.PnombreLinea = this.textBox2.Text;
                obj.PdescLinea = this.textBox3.Text;
                obj.PidMarca = long.Parse(this.comboBox1.SelectedValue.ToString());
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Registro con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarListaLinea();
                }
                else
                {
                    MessageBox.Show("***************************\nNo se pudo Registrar...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PidLinea = long.Parse(this.textBox1.Text);
                obj.PnombreLinea = this.textBox2.Text;
                obj.PdescLinea = this.textBox3.Text;
                obj.PidMarca = long.Parse(this.comboBox1.SelectedValue.ToString());
                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modifico con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarListaLinea();
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
