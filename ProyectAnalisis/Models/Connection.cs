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
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        private SqlConnection conec = new SqlConnection();

        public Connection()
        {
            builder.DataSource = "127.0.0.1";
            builder.UserID = "sa";
            builder.Password = "alone2020";
            builder.InitialCatalog = "USAID";
            builder.Encrypt = true;
            builder.TrustServerCertificate = true;

            conec = new SqlConnection(builder.ConnectionString);
        }

        public SqlConnection getConec()
        {
            try
            {
                conec.Open();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
            return conec;
        }

        public void CloseConection()
        {
            conec.Close();
        }
    }
}
