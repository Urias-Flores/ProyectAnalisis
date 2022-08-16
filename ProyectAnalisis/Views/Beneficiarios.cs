using Bunifu.Framework.UI;
using ProyectAnalisis.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectAnalisis.Entity;
using ProyectAnalisis.Components;

namespace ProyectAnalisis.Views
{
    public partial class Beneficiarios : Form
    {
        private ControllerBeneficiario controlller;

        public Beneficiarios()
        {
            InitializeComponent();
            controlller = new ControllerBeneficiario(txtNombre, txtApellido, txtDNI, txtFecha, cmbSexo, txtNumero, txtCorreo);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (verify()) {
                ClearFields();
            }
        }

        private bool verify() {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                txtError.Text = "El nombre es obligatorio";
                return false;
            }
            if (txtApellido.Text == "")
            {
                txtError.Text = "El Apellido es obligatorio";
                return false;
            }
            if (txtDNI.Text == "")
            {
                txtError.Text = "El DNI es obligatorio";
                return false;
            }
            if (cmbSexo.SelectedIndex == 0)
            {
                txtError.Text = "La seleccion del sexo es obligatorio";
                return false;
            }
            if (txtNumero.Text == "")
            {
                txtError.Text = "La numero de telefono es obligatorio";
                return false;
            }
            if (String.IsNullOrEmpty(txtCorreo.Text)) {
                txtError.Text = "La correo electronico es obligatorio";
                return false;
            }
            return true;
        }

        private void ClearFields() {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            cmbSexo.SelectedIndex = 0;
            txtNumero.Text = "";
            txtCorreo.Text = "";
        }


        private void Beneficiarios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() {
            using (USAIDEntities1 db = new USAIDEntities1()) {
                var ben = from b in db.Beneficiario select b;
                ben.ToList().ForEach(b => {
                    UserControl uc = Components.Components.getPanelBeneficiario(b.Nombre, b.Documento, b.Telefono, b.CorreoElectronico);
                    Pane.Controls.Add(uc);
                });
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (USAIDEntities1 db = new USAIDEntities1())
            {
                var ben = from b in db.Beneficiario select b;
                Pane.Controls.Clear();
                Console.WriteLine("Se probo: " + txtBuscar.Text + " \n");
                ben.ToList().ForEach(b => {
                    if (b.Nombre.Contains(txtBuscar.Text)) {
                        UserControl uc = Components.Components.getPanelBeneficiario(b.Nombre, b.Documento, b.Telefono, b.CorreoElectronico);
                        Pane.Controls.Add(uc);
                    }
                });
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
