using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IF4101_Lab1_Winform.Business;


namespace IF4101_Lab1_Winform.DataAccess
{
    class CountryDataAccess
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;
        private List<CountryBusiness> countryList;

        public CountryDataAccess()
        {

        }

        public void InsertIntoTbCountry(string countryName, int countryId)
        {
            string parameterName = "@COUNTRY_NAME", paramerCurrencyId = "@CURRENCY_ID", commandText = "COUNTRIES.sp_INSERT_COUNTRIES";
            this.InitSqlClientComponents(commandText);
            this.CreateParameter(parameterName, SqlDbType.VarChar, countryName);
            this.CreateParameter(paramerCurrencyId, SqlDbType.Int, countryId);
            this.ExecuteNonQuery();
        }

        public void DeleteCountry(string countryName)
        {
            string parameterName = "@COUNTRY_NAME", commandText = "COUNTRIES.sp_DELETE_COUNTRIES";
            this.InitSqlClientComponents(commandText);
            this.CreateParameter(parameterName, SqlDbType.VarChar, countryName);
            this.ExecuteNonQuery();
        }

        public List<CountryBusiness> GetCountriesList()
        {
            string commandText = "COUNTRIES.sp_GET_COUNTRIES_DATA";
            this.InitSqlClientComponents(commandText);
            this.ExecuteReaderQuery();
            return this.countryList;
        }

        private void InitSqlClientComponents(string commandText)
        {
            ConnectionDataAccess connectionDataAccess = new ConnectionDataAccess();
            this.sqlConnection = (SqlConnection)connectionDataAccess.ConnectToDatabase();
            this.sqlCommand = new SqlCommand(commandText, this.sqlConnection);
        }

        private void CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            this.sqlCommand.Parameters.Add(sqlParameter);
        }

        private void ExecuteNonQuery()
        {
            this.ExecuteConnectionCommands();
            this.sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
        }

        private void ExecuteReaderQuery()
        {
            this.ExecuteConnectionCommands();
            this.sqlDataReader = this.sqlCommand.ExecuteReader();
            this.CountryDataReader();
        }

        private void ExecuteConnectionCommands()
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
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
            this.sqlConnection.Close();
        }

    }
}
