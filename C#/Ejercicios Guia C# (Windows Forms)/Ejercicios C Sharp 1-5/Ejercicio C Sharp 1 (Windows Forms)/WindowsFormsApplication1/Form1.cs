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

           private void btnVerificar_Click_1(object sender, EventArgs e)
           {
               int numer1, numer2, rester;
               numer1 = Convert.ToInt32(txtNumero1.Text);
               numer2 = Convert.ToInt32(txtNumero2.Text);
               rester = numer1 - numer2;

               if (rester < 0)
               {
                   txtResultado.Text = "El Numero Negativo a Mostrar es = " + rester;
               }
               else
               {
                   txtResultado.Text = "No Hubo Numero Negativo que Mostrar";
               }

           }



        
    }
}
