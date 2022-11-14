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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int final, final2;

            txtResultados.Clear();

            final = Convert.ToInt32(txtN.Text);
            final2 = Convert.ToInt32(txtM.Text);

            while (final <= final2)
            {
                txtResultados.Text = txtResultados.Text + "," + final;
                final++;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
