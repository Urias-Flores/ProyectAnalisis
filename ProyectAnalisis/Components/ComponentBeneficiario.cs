using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis.Components
{
    public partial class ComponentBeneficiario : UserControl
    {
        private String Nombre;
        private String DNI;
        private String Numero;
        private String Correo;

        public ComponentBeneficiario(String Nombre, String DNI, String Numero, String Correo)
        {
            InitializeComponent();
            this.Nombre = Nombre;
            this.DNI = DNI;
            this.Numero = Numero;
            this.Correo = Correo;
            Load();
        }

        private void Load() 
        {
            lbNombre.Text = Nombre;
            lbDNI.Text = DNI;
            lbNumero.Text = Numero;
            lbCorreo.Text = Correo;
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
