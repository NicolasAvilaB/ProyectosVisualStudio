using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2,sum;

            txtResultados.Clear();
            n1 = Convert.ToInt32(txtNumer.Text);
            n2 = Convert.ToInt32(txtNumer2.Text);
            sum = Convert.ToInt32(txtintervalo.Text);
            while (n1 <= n2)
            {
                txtResultados.Text = txtResultados.Text + "," + n1;
                n2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2,i, sum;

            txtResultados.Clear();
            n1 = Convert.ToInt32(txtNumer.Text);
            n2 = Convert.ToInt32(txtNumer2.Text);
            sum = Convert.ToInt32(txtintervalo.Text);
            for (i = n1; i <= n2; i=(i+sum))
            {
                txtResultados.Text = txtResultados.Text + " " + i;
            }



        }

    

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
