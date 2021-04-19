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
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        // Connection to database

        private object connectToDatabase()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(getConnectionString());
                return sqlConnection;
            }
            catch (SqlException sqlException)
            {
                return sqlException.Number;
            }
        }

        private void executeStoredProcedure()
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
            this.sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
        }

        private void initSqlClientComponents(string comandText)
        {
            this.sqlConnection = (SqlConnection)connectToDatabase();
            this.sqlCommand = new SqlCommand(comandText, this.sqlConnection);
        }

        private SqlParameter createParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            return sqlParameter;
        }

        public void insertIntoTbCountry(string country_name, int currency_id)
        {
            string parameterName = "@COUNTRY_NAME";
            string paramerCurrencyId = "@CURRENCY_ID";
            string comandText = "COUNTRIES.sp_INSERT_COUNTRIES";
            this.initSqlClientComponents(comandText);
            this.sqlCommand.Parameters.Add(this.createParameter(parameterName, SqlDbType.VarChar, country_name));
            this.sqlCommand.Parameters.Add(this.createParameter(paramerCurrencyId, SqlDbType.Int, currency_id));
            this.executeStoredProcedure();
        }

        public void insertIntoTbCurrency()
        {

        }

        static private string getConnectionString()
        {
            return "Data Source=SPIEDRA\\MYSSQLSERVER; database=IF4101_LAB1_B97452; User Id=juan; Password=piedra";
        }
    }
}
