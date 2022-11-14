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

        private void btnResult_Click(object sender, EventArgs e)
        {
            int N_1;
            N_1 = Convert.ToInt32(txtNum1.Text);

            if (N_1 % 2 == 0)
            {
                txtResultparimpar.Text = "El Numero es PAR";
            }
            else
            {
                txtResultparimpar.Text = "El Numero es IMPAR";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
