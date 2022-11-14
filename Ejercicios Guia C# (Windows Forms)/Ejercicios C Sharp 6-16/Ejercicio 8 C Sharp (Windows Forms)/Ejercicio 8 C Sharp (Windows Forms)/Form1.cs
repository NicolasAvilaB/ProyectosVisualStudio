using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_8_C_Sharp__Windows_Forms_
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
            int compra, desc1, desc2,totaltotal, totaltotal2;
            compra = Convert.ToInt32(txtCompra.Text);
            desc1 = compra * 10 / 100;
            desc2 = compra * 15 / 100;
            totaltotal = compra - desc1; 
            totaltotal2 = compra - desc2;

            if (compra <= 10000)
            {
                dataGridView1.Rows.Add(txtCompra.Text,desc1, totaltotal);
            }
            else if (compra > 10000)
            {
                dataGridView1.Rows.Add(txtCompra.Text,desc2, totaltotal2);
            }

       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtCompra.Clear();
        }
    }
}
