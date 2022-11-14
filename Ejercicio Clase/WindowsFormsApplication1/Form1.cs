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

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int total, totalGeneral;
            total = Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);

            dataGridView1.Rows.Add(txtProducto.Text, txtPrecio.Text, txtCantidad.Text, total);

            totalGeneral = Convert.ToInt32(txtTotal.Text) + total;
            txtTotal.Text = Convert.ToString(totalGeneral);

            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
           
        }

      

        }
    }

