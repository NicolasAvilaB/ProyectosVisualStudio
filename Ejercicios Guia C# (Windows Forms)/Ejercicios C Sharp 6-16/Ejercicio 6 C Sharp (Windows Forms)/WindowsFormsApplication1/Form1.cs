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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int Precio, Clave, Desc1, Desc2, resta, resta2;
            Precio = Convert.ToInt32(txtPrecio.Text);
            Clave = Convert.ToInt32(txtClaves.Text);
            Desc1 = Precio * 10 / 100;
            Desc2 = Precio * 20 / 100;
            resta = Precio - Desc1;
            resta2 = Precio - Desc2;
            if (Clave == 1)
            {
                dataGridView1.Rows.Add(txtProducto.Text, txtPrecio.Text, resta,Desc1);
            }
            else 
            {
                dataGridView1.Rows.Add(txtProducto.Text, txtPrecio.Text, resta2,Desc2);
            }
            
           

        }

        private void txtClaves_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtClaves.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
        }

        

        
    }
}
