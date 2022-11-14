using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_7_C_Sharp__Windows_Forms_
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

        private void button1_Click(object sender, EventArgs e)
        {
            int camisas, precios, desc1, mult, desc2, total, total2;
            camisas = Convert.ToInt32(txtCantidad.Text);
            precios = Convert.ToInt32(txtPrecios.Text);
            mult = camisas * precios;
            desc1 = mult * 10 / 100;
            desc2 = mult * 20 / 100;
            total = mult - desc2;
            total2 = mult  - desc1;
            if (camisas >= 3)
            {
                dataGridView1.Rows.Add(txtCantidad.Text, txtPrecios.Text,desc2 , mult, total);
            }
            else if (camisas < 3)
            {
                dataGridView1.Rows.Add(txtCantidad.Text, txtPrecios.Text,desc1, mult, total2);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtCantidad.Clear();
            txtPrecios.Clear();
        }
    }
}
        
    

