using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Utilitario.Utilitario.cadena = System.Configuration.ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.SATConnectionString"].ConnectionString;

                Inicio.FrmLogin frmLogin = new Inicio.FrmLogin();
                Inicio.FrmPrincipal frmPrincipal = new Inicio.FrmPrincipal();
                if (frmLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    frmLogin.Close();
                    Application.Run(new Inicio.FrmPrincipal());
                }
                //Application.Run(new FrmPrincipal());
            }
            catch (Exception ex)
            {
                Application.Restart();  
            }
        }
    }
}
