using System;
using System.Data.SqlClient;

namespace WebApplication.Commands
{

    public class ConnectionSql
    {
        protected SqlConnection Con;

        public string StringConnection()
        {
            return "Server = DESKTOP-DH4FP6N; Database=exercicio;Trusted_Connection=True;";
        }

        public string Connection()
        {
            string conexao = "NOK";

            try
            {
                OpenConnection();
                if (Con.State != System.Data.ConnectionState.Open)
                {
                    return conexao;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            CloseConnection();
            return "OK";
        }

        public void OpenConnection()
        {
            Con = new SqlConnection(StringConnection());
            Con.Open();
        }

        public void CloseConnection()
        {
            Con = new SqlConnection(StringConnection());
            Con.Close();
        }

    }
}
