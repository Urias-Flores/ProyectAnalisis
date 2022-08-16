using ProyectAnalisis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Connection conec = new Connection();
            if (conec.getConec() != null) {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Admin")
            {
                if (txtContrasena.Text == "contrasena")
                {
                    Menu m = new Menu();
                    m.Visible = true;
                    this.Visible = false;
                }
                else 
                {
                    txtError.Text = "La contraseña es incorrecta";
                }
            }
            else {
                txtError.Text = "El usuario ingresado no existe";
            }
        }
    }
}
