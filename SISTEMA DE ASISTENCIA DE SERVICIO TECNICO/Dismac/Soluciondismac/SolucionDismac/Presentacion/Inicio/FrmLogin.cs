using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Inicio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        
        public bool VerificarUsuario()
        {
            try
            {
                bool respuesta = false;
                DataTable dt = null;
                Negocio.Usuario.Usuario  objUsuario = new Negocio.Usuario.Usuario ();
                objUsuario.PnombreUsuario = this.txtUsuario.Text.Trim();
                objUsuario.PcontraseñaUsuario = this.txtContraseña.Text.Trim();
                dt = objUsuario.VerificarUsuario();
                if (dt.Rows.Count == 0)
                {
                    respuesta = false;

                }
                else
                {
                    respuesta = true;
                    Utilitario.Utilitario.idPersona = int.Parse(dt.Rows[0]["idPersona"].ToString());
                    Utilitario.Utilitario.nombreUsuario = dt.Rows[0]["nombreUsuario"].ToString();
                    Utilitario.Utilitario.nombreRol = dt.Rows[0]["descRol"].ToString();
                    Utilitario.Utilitario.nombrePersona = dt.Rows[0]["nombrePersona"].ToString();
                    Utilitario.Utilitario.idUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private int veces = 0;
        const int NumeroIntentos = 3;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarUsuario() == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {

                    veces = veces + 1;
                    if (veces < NumeroIntentos)
                    {
                        MessageBox.Show("Quedan " + (NumeroIntentos - veces) + " intentos", "DISMAC Informa");
                        return;
                    }
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            this.txtUsuario.BackColor = Color.LightBlue; 
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            this.txtUsuario.BackColor = Color.White;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            this.txtContraseña.BackColor = Color.LightBlue; 
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            this.txtContraseña.BackColor = Color.White; 
        }

        private void btnConcelar_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de esta Aplicacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                Application.Exit(); 
            }
            
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            if (e.KeyValue == 13)
            {
                try
                {
                    if (VerificarUsuario() == true)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        veces = veces + 1;
                        if (veces < NumeroIntentos)
                        {
                            MessageBox.Show("Quedan " + (NumeroIntentos - veces) + " intentos", "DISMAC Informa");
                            return;
                        }
                        this.DialogResult = DialogResult.No;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Tipo:\n" + ex.Message);
                }
            }
        }
    }
}
