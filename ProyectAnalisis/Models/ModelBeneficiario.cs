using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAnalisis.Models
{
    internal class ModelBeneficiario
    {
        Connection conec = new Connection();
        private String Nombre;
        private String Apellido;
        private String DNI;
        private String Fecha;
        private String Sexo;
        private String Numero;
        private String Correo;
        #region
        public void setNombre(String Nombre) {
            this.Nombre = Nombre;
        }

        public String getNombre() { 
            return this.Nombre;
        }

        public void setApellido(String Apellido)
        {
            this.Apellido = Apellido;
        }

        public String getApellido()
        {
            return this.Apellido;
        }

        public void setDNI(String DNI)
        {
            this.DNI = DNI;
        }

        public String getDNI()
        {
            return this.DNI;
        }

        public void setFecha(String Fecha)
        {
            this.Fecha = Fecha;
        }

        public String getFecha()
        {
            return this.Fecha;
        }

        public void setSexo(String Sexo)
        {
            this.Sexo = Sexo;
        }

        public String getSexo()
        {
            return this.Sexo;
        }

        public void setNumero(String Numero)
        {
            this.Numero = Numero;
        }

        public String getNumero()
        {
            return this.Numero;
        }

        public void setCorreo(String Correo)
        {
            this.Correo = Correo;
        }

        public String getCorreo()
        {
            return this.Correo;
        }
        #endregion

        public void InsertBeneficiario() {
            try {
                //String Query = "INSERT INTO Beneficiario VALUES(1, '" + Nombre + "', '" + Apellido + "', '" + DNI + "', '" + Fecha + "', '" + Sexo + "', '" + Numero + "', '" + Correo + "')";
                String Query2 = "insert into Beneficiario VALUES(8, 'Lucas Mora', 'Hernandez Ferran', '3207825903289403', '032749032894', '2000-04-23', 'M', 'lucmora@gmail.com', 1, 7, 1, GETDATE())";
                SqlCommand sc = new SqlCommand(Query2, conec.getConec());
                sc.ExecuteNonQuery();
                MessageBox.Show("Se ejecuto el query descrito" ,"Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) {
                System.Console.WriteLine("Error: "+e);
            }
        }
    }
}
