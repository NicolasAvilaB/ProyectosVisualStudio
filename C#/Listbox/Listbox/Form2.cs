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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int i;


            num1 = Convert.ToInt32(txtNumer.Text);
           
            for (i = num1; i > num1; i++) ;
            Lista1.Items.Add(i);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
