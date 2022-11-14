using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_10_C_Sharp__Windows_Forms_
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

        private void btnMuestre_Click(object sender, EventArgs e)
        {
            int suelmensual, antpersona, desc1, desc2, desc3, suma, suma2, suma3;
            suelmensual = Convert.ToInt32(txtMensual.Text);
            antpersona = Convert.ToInt32(txtPersona.Text);
            desc1 = suelmensual * 5 / 100;
            desc2 = suelmensual * 7 / 100;
            desc3 = suelmensual * 10 / 100;
            suma = suelmensual + desc1;
            suma2 = suelmensual + desc2;
            suma3 = suelmensual + desc3;

            if (antpersona < 5)
            {
                dataGridView1.Rows.Add(txtMensual.Text, desc1, suma);
            }
            else if (antpersona >= 5 && antpersona <= 10)
            {
                dataGridView1.Rows.Add(txtMensual.Text, desc2, suma2);
            }
            else if (antpersona >= 10)
            {
                dataGridView1.Rows.Add(txtMensual.Text, desc3, suma3);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtMensual.Clear();
            txtPersona.Clear();
        }
    }
}
