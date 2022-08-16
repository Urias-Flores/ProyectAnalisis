using ProyectAnalisis.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            subMenuPrincipal.Visible = false;
            subMenuAdministracion.Visible = false;
            LoadForm(new Beneficiarios());
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuPrincipal);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuAdministracion);
        }

        private void HideSubMenu() {
            subMenuPrincipal.Visible = false;
            subMenuAdministracion.Visible = false;
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            LoadForm(new Beneficiarios());
            HideSubMenu();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            LoadForm(new Servicios());
            HideSubMenu();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            LoadForm(new Empleados());
            HideSubMenu();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            LoadForm(new Usuarios());
            HideSubMenu();
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {subMenu.Visible = false;}
            else
            {subMenu.Visible = true;}
        }

        private Form activeForm = null;
        private void LoadForm(Form newForm) {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            LoadPanel.Controls.Add(newForm);
            LoadPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Reportes());
            HideSubMenu();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
