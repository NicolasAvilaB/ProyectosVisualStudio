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
    public partial class FrmCambioContraseña : Form
    {
        public FrmCambioContraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea cancelar la Operacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }


        public void modificarContraseña()
        {
            try
            {
                Negocio.Usuario.Usuario obj = new Negocio.Usuario.Usuario();
                obj.PidUsuario = Utilitario.Utilitario.idUsuario;
                obj.PnombreUsuario = Utilitario.Utilitario.nombreUsuario;
                obj.PcontraseñaUsuario = this.textBox1.Text.Trim();
                Utilitario.Utilitario.nuevaContraseña = this.textBox2.Text.Trim();

                if (obj.ModificarContraseña() == 1)
                {
                    MessageBox.Show("***************************\nSe modofico la Contraseña con Exito...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("***************************\nNo se pudo modificar la contraseña...\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("***************************\nError de Tipo: \n " + ex.Message + "\n***************************", "SAT Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarContraseña()
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea cambiar la Contraseña?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                modificarContraseña();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.textBox1.Text.Trim().Equals("")) || (this.textBox2.Text.Trim().Equals("")) || (this.textBox3.Text.Trim().Equals("")))
                {
                    if ((this.textBox1.Text.Equals("")))
                    {
                        this.label4.Visible = true;
                    }
                    else
                    {
                        this.label4.Visible = false;
                    }

                    if ((this.textBox2.Text.Equals("")))
                    {
                        this.label5.Visible = true;
                    }
                    else
                    {
                        this.label5.Visible = false;
                    }

                    if ((this.textBox3.Text.Equals("")))
                    {
                        this.label6.Visible = true;
                    }
                    else
                    {
                        this.label6.Visible = false;
                    }
                    this.label7.Visible = true;
                }
                else
                {
                    this.label7.Visible = false;

                    if (this.textBox2.Text.Trim() == this.textBox3.Text.Trim())
                    {
                        this.label8.Visible = false;
                        CambiarContraseña();
                    }
                    else
                    {
                        this.label8.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo: \n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea cancelar la Operacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea cancelar la Operacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
