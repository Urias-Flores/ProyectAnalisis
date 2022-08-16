using Bunifu.UI.WinForms;
using ProyectAnalisis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAnalisis.Controllers
{
    internal class ControllerBeneficiario
    {
        ModelBeneficiario model = new ModelBeneficiario();

        BunifuTextBox Nombre;
        BunifuTextBox Apellido;
        BunifuTextBox DNI;
        BunifuDatePicker Fecha;
        BunifuDropdown Sexo;
        BunifuTextBox Numero;
        BunifuTextBox Correo;

        public ControllerBeneficiario(BunifuTextBox nombre, BunifuTextBox apellido, BunifuTextBox dNI, BunifuDatePicker fecha, BunifuDropdown sexo, BunifuTextBox numero, BunifuTextBox correo)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Fecha = fecha;
            Sexo = sexo;
            Numero = numero;
            Correo = correo;
        }

        public void InsertBeneficiario() {
            model.setNombre(Nombre.Text);
            model.setApellido(Apellido.Text);
            model.setDNI(DNI.Text);
            model.setFecha("2022-08-13");
            model.setSexo(Sexo.SelectedItem.ToString());
            model.setNumero(Numero.Text);
            model.setCorreo(Correo.Text);
            model.InsertBeneficiario();
        }
    }
}
