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

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2;
            Numero1 = Convert.ToInt32(txtNumer1.Text);
            Numero2 = Convert.ToInt32(txtNumer2.Text);

            if (Numero1 > Numero2)
            {
                txtResult.Text = "El Numero Mayor es  = " + Numero1;
                txtResult2.Text = "El Numero Menor es  = " + Numero2;
            }
            else
            {
                txtResult.Text = "El Numero Menor es  = " + Numero1;
                txtResult2.Text = "El Numero Mayor es  = " + Numero2;
            }
        }
    }
}
