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
            int number1, number2, mult, sumar, restar;
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            mult = number1 * number2;
            sumar = number1 + number2;
            restar = number1 - number2;

            if (number1 == number2)
            {
                txtResultado1.Text = "El Resultado de Los 2 Numeros Multiplicados es = " + mult;
            }
            else if (number1 > number2)
            {
                txtResultado1.Text = "El Resultado de Los 2 Numeros Restados es = " + restar;
            }
            else
            {
                txtResultado1.Text = "El Resultado de Los 2 Numeros Sumados es = " + sumar;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
