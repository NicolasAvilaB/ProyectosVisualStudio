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
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMarcas();
                CargarListaProducto();
            }
            catch (Exception ex)
            {

            }
        }


        public void CargarListaProducto()
        {
            try
            {
                Negocio.Producto.Producto obj = new Negocio.Producto.Producto();
                obj.PnombreProducto = "";
                this.lstBoxLista.DataSource = obj.Traer_Productos_Comodin();
                this.lstBoxLista.DisplayMember = "nombreProductos";
                this.lstBoxLista.ValueMember = "idProducto";
            }
            catch (Exception ex)
            {

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
                // MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarLineaporMarca();
            }
            catch (Exception ex)
            {

            }
        }

        public void CargarLineaporMarca()
        {
            try
            {
                Negocio.Producto.Linea obj = new Negocio.Producto.Linea();
                obj.PidMarca = int.Parse(this.comboBox1.SelectedValue.ToString());
                this.comboBox2.DataSource = obj.Traer_Linea_porMarca();
                this.comboBox2.DisplayMember = "nombreLinea";
                this.comboBox2.ValueMember = "idLinea";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Negocio.Producto.Modelo obj = new Negocio.Producto.Modelo();
                obj.PidLinea = long.Parse(this.comboBox2.SelectedValue.ToString());
                DataTable dt = obj.Traer_Modelo();

                this.comboBox3.Enabled = true;
                this.comboBox3.DataSource = dt;
                this.comboBox3.DisplayMember = "nombreModelo";
                this.comboBox3.ValueMember = "idModelo";

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


        public void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.CargarMarcas();
            this.textBox2.Focus();
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
                try
                {
                    Negocio.Producto.Producto obj = new Negocio.Producto.Producto();
                    obj.PnombreProducto = this.txboxBuscar.Text;
                    this.lstBoxLista.DataSource = obj.Traer_Productos_Comodin();
                    this.lstBoxLista.DisplayMember = "nombreProductos";
                    this.lstBoxLista.ValueMember = "idProducto";
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txboxBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txboxBuscar.Text.Trim().Equals(""))
            {
                this.txboxBuscar.Text = "Buscar";
            }
        }




        public void LlenarCampos()
        {
            try
            {
                Negocio.Producto.Producto obj = new Negocio.Producto.Producto();
                obj.PidProducto = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Productos_por_ID();
                if (dt.Rows.Count == 0)
                {

                }
                else
                {
                    this.textBox1.Text =dt.Rows[0]["idProducto"].ToString();
                    this.textBox2.Text = dt.Rows[0]["nombreProducto"].ToString();
                    this.comboBox1.SelectedValue = int.Parse(dt.Rows[0]["idMarca"].ToString());
                    this.comboBox2.SelectedValue = int.Parse(dt.Rows[0]["idLinea"].ToString());
                    this.comboBox3.SelectedValue = int.Parse(dt.Rows[0]["idModelo"].ToString());

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
                //Limpiar();
            }
            catch (Exception ex)
            {
 
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
                this.btnActualizar.Enabled = false;
                this.btnGuardar.Enabled = true;
                

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Producto.Producto obj = new Negocio.Producto.Producto();
                obj.PidProducto = 0;
                obj.PidModelo = long.Parse(this.comboBox3.SelectedValue.ToString());
                obj.PnombreProducto = this.textBox2.Text;
                obj.PiConcurrenciaProducto = 0;
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modico con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarListaProducto();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Producto.Producto obj = new Negocio.Producto.Producto();
                obj.PidProducto = 0;
                obj.PidModelo = long.Parse(this.comboBox3.SelectedValue.ToString());
                obj.PnombreProducto = this.textBox2.Text;
                obj.PiConcurrenciaProducto = 0;
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modico con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarListaProducto();
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
