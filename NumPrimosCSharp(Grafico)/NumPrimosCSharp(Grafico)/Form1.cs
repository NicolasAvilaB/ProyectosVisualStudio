using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumPrimosCSharp_Grafico_
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1.Focus();
            num1.Select();
        }

        private void calculador_Click(object sender, EventArgs e)
        {
       
            Int64.Parse(num1.Text);
            if (string.IsNullOrEmpty(num1.Text))
            {
                MessageBox.Show("Error: No Existe un Numero Ingresado en el Campo Numero", "Error, Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num1.Focus();
                num1.Select();
            }
            else {
                int a = 0;
                for (int i = 1; (i <= (Convert.ToInt64(num1.Text) + 1)); i++)
                {
                    if ((int.Parse(num1.Text) % i) == 0)
                    {
                        a = (a + 1);
                    }

                }
                if (a != 2)
                {
                    MessageBox.Show("El Numero " + num1.Text + " No es Primo", "Numero No Primo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    num1.Clear();
                    num1.Focus();
                    num1.Select();
                }
                else
                {
                    MessageBox.Show("El Numero " + num1.Text + " Si es Primo", "Numero Primo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    num1.Clear();
                    num1.Focus();
                    num1.Select();
                }
            }
        }
    }
}
