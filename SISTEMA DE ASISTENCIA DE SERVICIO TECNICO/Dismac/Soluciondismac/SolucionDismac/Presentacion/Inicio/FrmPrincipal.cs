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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarOrdenTrabajo obj = new frmRegistrarOrdenTrabajo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea cerrar la session actual?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                Application.Restart(); 
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            this.timer1.Start();
            this.timer1.Interval = 1000;
            cargarDatosUsuario();
        }

        public void cargarDatosUsuario()
        {
            try
            {
               
                toolStripStatusLabel2.Text = Utilitario.Utilitario.nombreUsuario;
                toolStripStatusLabel4.Text = Utilitario.Utilitario.nombreRol;
                toolStripStatusLabel6.Text = Utilitario.Utilitario.nombrePersona;

                if (Utilitario.Utilitario.nombreRol.ToString().ToUpper() == "ADMINISTRADOR")
                {
                    usuariosToolStripMenuItem.Enabled=true;
                    rolesYPermisosToolStripMenuItem.Enabled = true;
                    mnuParametros.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                }

                if (Utilitario.Utilitario.nombreRol.ToString().ToUpper() == "GERENTE")
                {
                    reportesToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Tipo:\n" + ex.Message);
            }
        }

        private void toolStripStatusLabel8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel9.Text = DateTime.Now.ToLongDateString() + "    " + DateTime.Now.ToLongTimeString();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void solicitudDeRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmDetalleOrdendeTrabajo obj = new FrmDetalleOrdendeTrabajo();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void registrarAsignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarDesperfectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registrarInformeFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario obj = new FrmRegistrarUsuario();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void garantiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controlDeGarantiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmControlGarantia obj = new FrmControlGarantia();
            obj.MdiParent = this;
            obj.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeGarantiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarGarantia obj = new FrmRegistrarGarantia();
            obj.MdiParent = this;
            obj.Show();
        }

        private void anularGarantiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnularGarantia obj = new FrmAnularGarantia();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmRegistraInforme obj = new FrmRegistraInforme();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRegistrarAsignacion obj = new FrmRegistrarAsignacion();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmRegistarRepuesto obj = new FrmRegistarRepuesto();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmRegistrarServicio obj = new FrmRegistrarServicio();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRegistrarInformeFinal obj = new FrmRegistrarInformeFinal();
            obj.MdiParent = this;
            obj.Show();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioContraseña obj = new FrmCambioContraseña();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ordenesDeTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmTrabajosRealizados obj = new FrmTrabajosRealizados();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarMarca obj = new FrmRegistrarMarca();
            obj.MdiParent = this;
            obj.Show();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistraLinea obj = new FrmRegistraLinea();
            obj.MdiParent = this;
            obj.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarModelo obj = new FrmRegistrarModelo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuParametroProducto_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto obj = new FrmRegistrarProducto();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
