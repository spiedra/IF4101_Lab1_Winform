using System;
using System.Collections.Generic;
using System.Text;
using IF4101_Lab1_Winform.DataAccess;

namespace IF4101_Lab1_Winform.Business
{
    class CalculatorBusiness
    {
        private ConnectionDataAccess connectionDataAccess;
        public CalculatorBusiness()
        {
            this.connectionDataAccess = new ConnectionDataAccess();
        }

        public decimal CalculateCurrencyExchange(decimal currencyFrom, decimal currencyTo, decimal amount)
        {
            return Math.Round(amount/(currencyFrom / currencyTo), 2);
        }

        public decimal GetDollarValueCurrency(string countryName)
        {
            return Math.Round(this.connectionDataAccess.GetDollarValueCurrency(countryName),2);
        }

        public decimal GetExchangeProfit(decimal total)
        {
            return total + Math.Round((2*total)/100, 2);
        }
    }
}
