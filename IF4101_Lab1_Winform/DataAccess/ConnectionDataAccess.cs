using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IF4101_Lab1_Winform.Business;

namespace IF4101_Lab1_Winform.DataAccess
{
    class ConnectionDataAccess
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;
        // Connection to database

        public ConnectionDataAccess()
        {
            this.ConnectToDatabase();
        }

        public object ConnectToDatabase()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(GetConnectionString());
                return sqlConnection;
            }
            catch (SqlException sqlException)
            {
                return sqlException.Number;
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=163.178.107.10; database=IF4101_B97452_LAB1; User Id=laboratorios; Password=KmZpo.2796";
        }
    }
}
