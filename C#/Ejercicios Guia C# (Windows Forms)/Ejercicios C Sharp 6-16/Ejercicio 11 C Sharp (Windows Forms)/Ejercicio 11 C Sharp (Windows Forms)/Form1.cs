using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_11_C_Sharp__Windows_Forms_
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

        private void btnCompruebe_Click(object sender, EventArgs e)
        {
            int com, mult, precio, desc1, desc2;
            com = Convert.ToInt32(txtComisiones.Text);
            precio = Convert.ToInt32(txtPrecio.Text);
            mult = com * precio;
            desc1 = mult * 10 / 100;
            desc2 = mult * 90 / 100;
            dataGridView1.Rows.Add(mult, desc1, desc2);
         }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtComisiones.Clear();
            txtPrecio.Clear();
        }
    }
}
