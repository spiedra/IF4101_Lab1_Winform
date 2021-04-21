using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IF4101_Lab1_Winform.Business;

namespace IF4101_Lab1_Winform.DataAccess
{
    class CurrencyDataAccess
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;
        private List<CurrencyBusiness> currencyList;

        public CurrencyDataAccess()
        {

        }

        public List<CurrencyBusiness> GetCurrencyData()
        {
            string commandText = "CURRENCY.sp_GET_CURRENCY_DATA";
            this.ExecuteReaderCurrencyData(commandText);
            return this.currencyList;
        }

        private void ExecuteReaderCurrencyData(string commandText)
        {
            this.InitSqlClientComponents(commandText);
            this.ExecuteConnectionCommands();
            this.ReadCurrencyData();
        }

        public decimal GetDollarValueCurrency(string countryName)
        {
            this.ExecuteReaderDollarValue(countryName);
            return this.ReadDollarValue();
        }

        private void ExecuteReaderDollarValue(string countryName)
        {
            string parameterName = "@COUNTRY_NAME", commandText = "CURRENCY.sp_GET_DOLLAR_VALUE_CURRENCY";
            this.InitSqlClientComponents(commandText);
            this.CreateParameter(parameterName, SqlDbType.VarChar, countryName);
            this.ExecuteConnectionCommands();
        }

        private void ExecuteConnectionCommands()
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
            this.sqlDataReader = this.sqlCommand.ExecuteReader();
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

        private void ReadCurrencyData()
        {
            this.currencyList = new List<CurrencyBusiness>();
            while (this.sqlDataReader.Read())
{
                CurrencyBusiness currencyDataAccess = new CurrencyBusiness(this.sqlDataReader.GetInt32(0),
                    this.sqlDataReader.GetString(1), this.sqlDataReader.GetDecimal(2));
                this.currencyList.Add(currencyDataAccess);
            }
            this.sqlConnection.Close();
        }

        private decimal ReadDollarValue()
        {
            while (this.sqlDataReader.Read())
                return this.sqlDataReader.GetDecimal(0);

            this.sqlConnection.Close();
            return 0;
        }
    }
}
