using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int presta, cuotas, inter1, inter2, prec_cuotas, prestinter, prestinter2;
            presta = Convert.ToInt32(txtPrestamo.Text);
            cuotas = Convert.ToInt32(txtCuotas.Text);
            inter1 = presta * 3 / 100;
            inter2 = presta * 2 / 100;
            prec_cuotas = presta / cuotas;

            if (presta < 1000000)
            {
                prestinter = inter1 + presta;
                dataGridView1.Rows.Add(txtPrestamo.Text, txtCuotas.Text,inter1, prec_cuotas, prestinter);
            }
            else if (presta >= 1000000)
            {
                prestinter2 = inter2 + presta;
                dataGridView1.Rows.Add(txtPrestamo.Text, txtCuotas.Text,inter2, prec_cuotas, prestinter2);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtPrestamo.Clear();
            txtCuotas.Clear();
        }
    }
}
