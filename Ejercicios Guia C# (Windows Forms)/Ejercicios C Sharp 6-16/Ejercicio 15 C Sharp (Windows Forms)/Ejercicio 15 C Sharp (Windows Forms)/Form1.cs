using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_15_C_Sharp__Windows_Forms_
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

        private void btnResultados_Click(object sender, EventArgs e)
        {
            int prec_total, desc1, desc2, total, total2, n_azar;
            prec_total = Convert.ToInt32(txtTotalCompra.Text);
            n_azar = Convert.ToInt32(txtN_Escogido.Text);
            desc1 = prec_total * 15 / 100;
            desc2 = prec_total * 20 / 100;
            total = prec_total - desc1;
            total2 = prec_total - desc2;

            if (n_azar < 74)
            {
                dataGridView1.Rows.Add(txtTotalCompra.Text, desc1, n_azar, total);
            }
            else if (n_azar >= 74)
            {
                dataGridView1.Rows.Add(txtTotalCompra.Text, desc2, n_azar, total2);
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtTotalCompra.Clear();
            txtN_Escogido.Clear();
        }
    }
}
