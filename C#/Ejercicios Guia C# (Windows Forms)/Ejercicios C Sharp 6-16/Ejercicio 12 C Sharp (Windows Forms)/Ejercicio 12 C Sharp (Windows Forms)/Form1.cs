using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_12_C_Sharp__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad, precios1, precios2;
            cantidad = Convert.ToInt32(txtFotos.Text);
            precios1 = cantidad * 200;
            precios2 = cantidad * 150;
            if (cantidad < 15)
            {
                dataGridView1.Rows.Add(txtFotos.Text, precios1);
            }
            else if (cantidad >= 15)
            {
                dataGridView1.Rows.Add(txtFotos.Text, precios2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtFotos.Clear();
        }      
    }
}
