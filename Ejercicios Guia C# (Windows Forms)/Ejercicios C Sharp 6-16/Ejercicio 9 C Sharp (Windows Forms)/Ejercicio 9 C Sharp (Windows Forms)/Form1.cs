using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_9_C_Sharp__Windows_Forms_
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
            int desc1, compra,totalpagar;
            compra = Convert.ToInt32(txtCompra.Text);
            desc1 = compra * 10 / 100;
            totalpagar = compra - desc1;
            dataGridView1.Rows.Add(txtCompra.Text, desc1, totalpagar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtCompra.Clear();
        }
    }
}
