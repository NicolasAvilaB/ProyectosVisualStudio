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
    public partial class FrmRegistrarMarca : Form
    {
        public FrmRegistrarMarca()
        {
            InitializeComponent();
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
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PdescMarca = this.txboxBuscar.Text;
                this.lstBoxLista.DataSource = obj.Traer_Marca_Comodin();
                this.lstBoxLista.DisplayMember = "nombreMarcas";
                this.lstBoxLista.ValueMember = "idMarca";
            }
            catch (Exception ex)
            {

            }
        }

        public void CargarMarca()
        {
            try
            {
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PidMarca = 0;
                this.lstBoxLista.DataSource = obj.Traer_Marca_porId();
                this.lstBoxLista.DisplayMember = "nombreMarcas";
                this.lstBoxLista.ValueMember = "idMarca";
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmRegistrarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMarca();
            }
            catch (Exception ex)
            {
 
            }
        }


        public void LlenarCampos()
        {
            try
            {
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PidMarca = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_Marca_porId();
                if (dt.Rows.Count == 0)
                {

                }
                else
                {
                    this.textBox1.Text = dt.Rows[0]["idMarca"].ToString();
                    this.textBox2.Text = dt.Rows[0]["nombreMarca"].ToString();
                    this.textBox3.Text = dt.Rows[0]["descMarca"].ToString();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnActualizar.Enabled = false;
            this.btnGuardar.Enabled = true;
            Limpiar();
        }

        public void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox1.Focus();
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
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PidMarca = 0;
                obj.PnombreMarca = this.textBox2.Text;
                obj.PdescMarca = this.textBox3.Text;
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Registro con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarMarca();
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
                Negocio.Producto.Marca obj = new Negocio.Producto.Marca();
                obj.PidMarca = long.Parse(this.textBox1.Text);
                obj.PnombreMarca = this.textBox2.Text;
                obj.PdescMarca = this.textBox3.Text;
                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modifico con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarMarca();
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
