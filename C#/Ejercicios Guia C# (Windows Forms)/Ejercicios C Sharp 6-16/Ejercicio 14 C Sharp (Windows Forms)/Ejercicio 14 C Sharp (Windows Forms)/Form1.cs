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

        private void btnComp_Click(object sender, EventArgs e)
        {
            int Cantidad,Precios, Precios2, mult, mult2;
            Cantidad = Convert.ToInt32(txtCantidad.Text);
            Precios = 40000;
            Precios2 = 35000;
            mult = Cantidad * 40000;
            mult2 = Cantidad * 35000;

            if (Cantidad <= 4)
            {
                dataGridView1.Rows.Add(txtCantidad.Text, Precios, mult);
            }
            else if (Cantidad >= 5)
            {
                dataGridView1.Rows.Add(txtCantidad.Text, Precios2, mult2);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtCantidad.Clear();
        }
    }
}
