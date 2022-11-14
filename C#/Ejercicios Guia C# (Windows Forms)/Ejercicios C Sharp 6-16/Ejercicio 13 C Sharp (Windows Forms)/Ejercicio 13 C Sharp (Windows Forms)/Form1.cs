using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_13_C_Sharp__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int cant, precio, desc1, desc2, resta, resta2, mult;
            cant = Convert.ToInt32(txtCant.Text);
            precio = Convert.ToInt32(txtPrecio.Text);
            mult = cant * precio;
            desc1 = mult * 10 / 100;
            desc2 = mult * 15 / 100;
            resta = mult - desc1;
            resta2 = mult - desc2;

            if (cant < 2)
            {
                dataGridView1.Rows.Add(txtCant.Text,mult,"0", txtPrecio.Text);
            }
            else if (cant >= 2 && cant <= 5)
            {
                dataGridView1.Rows.Add(txtCant.Text,mult, desc1, resta);
            }
            else if (cant >= 5)
            {
                dataGridView1.Rows.Add(txtCant.Text,mult, desc2, resta2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtCant.Clear();
            txtPrecio.Clear();
        }
    }
}
