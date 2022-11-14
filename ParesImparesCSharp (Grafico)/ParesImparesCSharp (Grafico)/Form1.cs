using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParesImparesCSharp__Grafico_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numero1.Focus();
            numero1.Select();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void calculador_Click(object sender, EventArgs e)
        {
                       
            if (string.IsNullOrEmpty(numero1.Text))
            {
                MessageBox.Show("Error: No Existe un Numero Ingresado en el Campo Numero","Error, Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numero1.Focus();
                numero1.Select();
            }
            else
            {
                if (double.Parse(numero1.Text) % 2 != 0)
                {
                    MessageBox.Show("El Numero " + numero1.Text + " Es Impar","Numero Impar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numero1.Clear();
                    numero1.Focus();
                    numero1.Select();
                }
               else
                {
                    MessageBox.Show("El Numero " + numero1.Text + " Es Par", "Numero Par", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numero1.Clear();
                    numero1.Focus();
                    numero1.Select();
                }

            }

            
        }
    }
}
