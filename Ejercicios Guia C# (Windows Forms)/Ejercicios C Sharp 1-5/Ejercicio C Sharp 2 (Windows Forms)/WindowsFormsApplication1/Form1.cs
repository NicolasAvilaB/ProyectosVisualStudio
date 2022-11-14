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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, multiplicacion;
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            multiplicacion = number1 * number2;

            if (multiplicacion > 100)

                txtResultado.Text = "El Resultado Mayor a 100 ya Multiplicado es = " + multiplicacion;
            else

                txtResultado.Text  = "No hubo numero mayor a multiplicar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
