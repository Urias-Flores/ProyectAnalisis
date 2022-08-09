using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAnalisis.Models
{
    internal class Connection
    {
        private SqlConnection conec = new SqlConnection();

        public Connection()
        {
            try
            {
                SqlConnection conec = new SqlConnection("server=127.0.0.1 ; " +
                                                    "user=sa; " +
                                                    "password=alone2020; " +
                                                    "database=USAID; " +
                                                    "integrated security = true; " +
                                                    "encrypt=true; " +
                                                    "trustServerCertificate=true;");
                conec.Open();
                System.Console.WriteLine("Conexion Establecida");
            }
            catch
            {
                System.Console.WriteLine("Error al intentar conexion");
            }
        }

        public SqlConnection getConec()
        {
            return conec;
        }

        public void CloseConection()
        {
            conec.Close();
        }
    }
}
