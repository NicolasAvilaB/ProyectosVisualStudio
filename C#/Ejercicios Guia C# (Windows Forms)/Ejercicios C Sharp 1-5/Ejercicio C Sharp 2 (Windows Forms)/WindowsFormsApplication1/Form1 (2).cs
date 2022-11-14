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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resta;
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            resta = numero1 - numero2;

            if (resta < 0)
            {
                txtResultado.Text = "El Numero Negativo es = " + resta;
            }
            else
            {

                txtResultado.Text = " No hay Numero Negativo que Mostrar";
            }
        }
    }
}
