using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login_Mysql_C_Sharp
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexion = new MySqlConnection("server=Localhost;Database=csharp;Uid=root;Password=root");
     
      
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
          
        }
        
    }
    
}

