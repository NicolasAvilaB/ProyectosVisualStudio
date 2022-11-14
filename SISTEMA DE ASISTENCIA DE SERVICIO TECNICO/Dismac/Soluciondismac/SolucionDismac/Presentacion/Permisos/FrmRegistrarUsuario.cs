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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }




        public void CargarRol()
        {
            Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
            this.comboBox1.DataSource = obj.Traer_Rol();
            this.comboBox1.DisplayMember = "descRol";
            this.comboBox1.ValueMember = "idRol";
        }

        public void CargarEmpleado()
        {
            Negocio.Usuario.Personanatural obj = new Negocio.Usuario.Personanatural();
            this.comboBox2.DataSource = obj.Traer_Empleado();
            this.comboBox2.DisplayMember = "nombrePersona";
            this.comboBox2.ValueMember = "idPersona";
        }


        public void CargarUsuarioLista()
        {
            Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
            obj.PidUsuario = 0;
            this.lstBoxLista.DataSource = obj.Traer_ListaUsuarios();
            this.lstBoxLista.DisplayMember = "nombreUsuarios";
            this.lstBoxLista.ValueMember = "idUsuario";
        }

       

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarRol();
                CargarEmpleado();
                CargarUsuarioLista();
            }
            catch(Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = true;
            this.btnActualizar.Enabled = false;
            Limpiar();
        }


        public void LlenarCampos()
        {
            try
            {
                Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
                obj.PidUsuario = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                DataTable dt = obj.Traer_ListaUsuarios();
                if (dt.Rows.Count == 0)
                {

                }
                else
                {
                    this.comboBox1.SelectedValue = int.Parse(dt.Rows[0]["idRol"].ToString());
                    this.comboBox2.SelectedValue = int.Parse(dt.Rows[0]["idPersona"].ToString());
                    this.txtusuario.Text = dt.Rows[0]["nombreUsuario"].ToString();
                    this.txtcontra.Text = dt.Rows[0]["contraseñaUsuario"].ToString();
                    this.txtnueva.Text = dt.Rows[0]["contraseñaUsuario"].ToString();

                    if (int.Parse(dt.Rows[0]["estadoUsuario"].ToString()) == 1)
                    {
                        rbtActivo.Checked = true;
                    }
                    else
                    {
                        rbtInactivo.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
 
            }
        }

        private void lstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = false;
            this.btnActualizar.Enabled = true;
            LlenarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( (this.txtcontra.Text.Trim().Equals("")) || (this.txtnueva.Text.Trim().Equals("")))
                {
                 
                    if ((this.txtcontra.Text.Equals("")))
                    {
                        this.label6.Visible = true;
                    }
                    else
                    {
                        this.label6.Visible = false;
                    }

                    if ((this.txtnueva.Text.Equals("")))
                    {
                        this.label7.Visible = true;
                    }
                    else
                    {
                        this.label7.Visible = false;
                    }
                    this.label11.Visible = true;
                }
                else
                {
                    this.label11.Visible = false;

                    if (this.txtcontra.Text.Trim() == this.txtnueva.Text.Trim())
                    {
                        this.label10.Visible = false;
                        this.label6.Visible = false;
                        this.label7.Visible = false;
                        GuardarUsuario();
                    }
                    else
                    {
                        this.label10.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void GuardarUsuario()
        {
            try
            {
                Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
                obj.PidUsuario = 0;
                obj.PnombreUsuario = this.txtusuario.Text.Trim();
                obj.PcontraseñaUsuario = this.txtcontra.Text.Trim();
                obj.PidRol = long.Parse(this.comboBox1.SelectedValue.ToString());
                obj.PidPersona = long.Parse(this.comboBox2.SelectedValue.ToString());
                obj.PiConcurrenciaUsuario = 0;
                if (rbtActivo.Checked == true)
                {
                    obj.PestadoUsuario = 1;
                }
                else
                {
                    obj.PestadoUsuario = 0;
                }
                if (obj.Guardar() == 1)
                {
                    MessageBox.Show("***************************\nSe Guardo Con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarUsuarioLista();
                    Limpiar();
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





        public void ModificarUsuario()
        {
            try
            {
                Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
                obj.PidUsuario = long.Parse(this.lstBoxLista.SelectedValue.ToString());
                obj.PnombreUsuario = this.txtusuario.Text.Trim();
                obj.PcontraseñaUsuario = this.txtcontra.Text.Trim();
                obj.PidRol = long.Parse(this.comboBox1.SelectedValue.ToString());
                obj.PidPersona = long.Parse(this.comboBox2.SelectedValue.ToString());
                obj.PiConcurrenciaUsuario = 0;
                if (rbtActivo.Checked == true)
                {
                    obj.PestadoUsuario = 1;
                }
                else
                {
                    obj.PestadoUsuario = 0;
                }
                if (obj.Modificar() == 1)
                {
                    MessageBox.Show("***************************\nSe Modifico Con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CargarUsuarioLista();
                    Limpiar();
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




        private void txboxBuscar_Enter(object sender, EventArgs e)
        {
            this.txboxBuscar.Text = "";
        }

        private void txboxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //buscarOrdenes();
            }
        }

        private void txboxBuscar_Leave(object sender, EventArgs e)
        {
            if (this.txboxBuscar.Text.Trim().Equals(""))
            {
                this.txboxBuscar.Text = "Buscar";
            }
        }


        public void Limpiar()
        {
            this.CargarRol();
            this.CargarEmpleado();
            this.txtusuario.Text = "";
            this.txtcontra.Text = "";
            this.txtnueva.Text = "";
            this.txtusuario.Focus();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
