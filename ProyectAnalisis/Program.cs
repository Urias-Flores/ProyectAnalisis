using ProyectAnalisis.Models;
using ProyectAnalisis.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection conec = new Connection();

            if (conec.getConec() != null)
            {
                Application.Run(new Menu());
            }
            else {
                MessageBox.Show("Conexion no establecida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
