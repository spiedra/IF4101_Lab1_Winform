using System;
using System.Collections.Generic;
using System.Text;
// To connection
using System.Data;
using System.Data.SqlClient;

namespace IF4101_Lab1_Winform.DataAccess
{
    class ConnectionDataAccess
    {
        // Connection to database

        public bool connectToDatabase()
        {
            try
            {
                string connectionString = getConnectionString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "INSERT INTO [COUNTRIES].[tb_COUNTRY]([COUNTRY_NAME],[CURRENCY_ID]) VALUES('JAJJAJJ', 2)";
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false; 
            }
           
        }

        static private string getConnectionString()
        {
            return "Data Source=SPIEDRA\\MYSSQLSERVER; database=IF4101_LAB1_B97452; User Id=juan; Password=piedra";
        }
    }
}
