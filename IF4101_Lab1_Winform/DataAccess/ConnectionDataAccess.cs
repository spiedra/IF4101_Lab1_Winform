using System.Collections;
using System.Collections.Generic;
// To connection
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
        private List<CurrencyBusiness> currencyList;
        // Connection to database

        public ConnectionDataAccess()
        {
            this.ConnectToDatabase();
        }

        private object ConnectToDatabase()
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

        private void ExecuteStoredProcedure(bool conditional)
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
            this.ExcecuteSqlCommand(conditional);
            //this.sqlConnection.Close();
        }

        private void InitSqlClientComponents(string comandText)
        {
            this.sqlConnection = (SqlConnection)ConnectToDatabase();
            this.sqlCommand = new SqlCommand(comandText, this.sqlConnection);
        }

        private void CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            this.sqlCommand.Parameters.Add(parameterName, SqlDbType.VarChar);
        }

        public void InsertIntoTbCountry(string country_name, int currency_id)
        {
            bool isExcuteNonQuery = true;
            string parameterName = "@COUNTRY_NAME", paramerCurrencyId = "@CURRENCY_ID", comandText = "COUNTRIES.sp_INSERT_COUNTRIES";
            this.InitSqlClientComponents(comandText);
            this.CreateParameter(parameterName, SqlDbType.VarChar, country_name);
            this.CreateParameter(paramerCurrencyId, SqlDbType.Int, currency_id);
            this.ExecuteStoredProcedure(isExcuteNonQuery);
        }

        public void InsertIntoTbCurrency()
        {

        }

        public List<CurrencyBusiness> GetCurrencyData()
        {
            bool isExcuteReader = false;
            string comandText = "CURRENCY.sp_GET_CURRENCY_DATA";
            this.InitSqlClientComponents(comandText);
            this.ExecuteStoredProcedure(isExcuteReader);
            this.ReadCurrencyData();
            this.sqlConnection.Close();
            return this.currencyList;
        }

        private void ReadCurrencyData()
        {
            this.currencyList = new List<CurrencyBusiness>();
            while (this.sqlDataReader.Read())
            {
                CurrencyBusiness currencyDataAccess = new CurrencyBusiness();
                currencyDataAccess.CurrencyId = this.sqlDataReader.GetInt32(0);
                currencyDataAccess.CurrencyName = this.sqlDataReader.GetString(1);
                currencyDataAccess.DollaValue = this.sqlDataReader.GetInt32(2);
                this.currencyList.Add(currencyDataAccess);
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=SPIEDRA\\MYSSQLSERVER; database=IF4101_LAB1_B97452; User Id=juan; Password=piedra";
        }

        private void ExcecuteSqlCommand(bool conditional)
        {
            if (conditional)
            {
                this.sqlCommand.ExecuteNonQuery();
            }
            else
            {
                this.sqlDataReader = this.sqlCommand.ExecuteReader();
            }
        }
    }
}
