using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis.Components
{
    internal class Components
    {
        public static UserControl getPanelBeneficiario(String Nombre, String DNI, String Numero, String Correo) {
            ComponentBeneficiario cardBeneficiario = new ComponentBeneficiario(Nombre, DNI, Numero, Correo);
            return cardBeneficiario;
        }
    }
}
