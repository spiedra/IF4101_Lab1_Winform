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
        private List<CountryBusiness> countryList;
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

        private void ExecuteNonQuery()
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
            this.sqlCommand.ExecuteNonQuery();
        }

        private void ExecuteReaderQuery(string commandText, bool conditional)
        {
            this.InitSqlClientComponents(commandText);
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
            this.sqlDataReader = this.sqlCommand.ExecuteReader();
            this.ReadObjectData(conditional);
            this.SqlConnectionClose();
        }

        private void InitSqlClientComponents(string commandText)
        {
            this.sqlConnection = (SqlConnection)ConnectToDatabase();
            this.sqlCommand = new SqlCommand(commandText, this.sqlConnection);
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
            //this.ExecuteStoredProcedure(isExcuteNonQuery);
            this.SqlConnectionClose();
        }

        public List<CurrencyBusiness> GetCurrencyData()
        {
            string commandText = "CURRENCY.sp_GET_CURRENCY_DATA";
            this.ExecuteReaderQuery(commandText, true);
            return this.currencyList;
        }


        public List<CountryBusiness> GetCountryData()
        {
            string commandText = "COUNTRIES.sp_GET_COUNTRIES_DATA";
            this.ExecuteReaderQuery(commandText, false);
            return this.countryList;
        }

        private void ReadObjectData(bool conditional)
        {
            if (conditional)
            {
                this.CurrencyDataReader();
            }
            else
            {
                this.CountryDataReader();
            }
           
        }

        private void CurrencyDataReader()
        {
            this.currencyList = new List<CurrencyBusiness>();
            while (this.sqlDataReader.Read())
            {
                CurrencyBusiness currencyDataAccess = new CurrencyBusiness(this.sqlDataReader.GetInt32(0),
                    this.sqlDataReader.GetString(1), this.sqlDataReader.GetInt32(2));
                this.currencyList.Add(currencyDataAccess);
            }
        }

        private void CountryDataReader()
        {
            this.countryList = new List<CountryBusiness>();
            while (this.sqlDataReader.Read())
            {
                CountryBusiness countryBusiness = new CountryBusiness(this.sqlDataReader.GetInt32(0),
                    this.sqlDataReader.GetInt32(1), this.sqlDataReader.GetString(2));
                this.countryList.Add(countryBusiness);
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=SPIEDRA\\MYSSQLSERVER; database=IF4101_LAB1_B97452; User Id=juan; Password=piedra";
        }

        private void SqlConnectionClose()
        {
            this.sqlConnection.Close();
        }
    }
}
