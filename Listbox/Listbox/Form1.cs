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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text != "")

            {
                listBox1.Items.Add(txtTexto.Text);
                txtTexto.Clear();
                txtTexto.Focus();
            }
            else{
                MessageBox.Show("Error, Error, Error"); 
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un Item Pepito");
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un Item Pepito");
            }
          
        }

        private void btnTodosDer_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void btnTodosIzq_Click(object sender, EventArgs e)
        {
            int i;

            for (i=0; i < listBox2.Items.Count;i++){
                listBox1.Items.Add(listBox2.Items[i]);
            }
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
