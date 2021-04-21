using System;
using System.Collections.Generic;
using System.Text;
using IF4101_Lab1_Winform.DataAccess;

namespace IF4101_Lab1_Winform.Business
{
    class CalculatorBusiness
    {
        private CurrencyDataAccess currencyDataAccess;
        public CalculatorBusiness()
        {
            this.currencyDataAccess = new CurrencyDataAccess();
        }

        public decimal CalculateCurrencyExchange(decimal currencyFrom, decimal currencyTo, decimal amount)
        {
            return Math.Round(amount/(currencyFrom / currencyTo), 2);
        }

        public decimal GetDollarValueCurrency(string countryName)
        {
            return Math.Round(this.currencyDataAccess.GetDollarValueCurrency(countryName),2);
        }

        public decimal GetExchangeProfit(decimal total)
        {
            return total + Math.Round((2*total)/100, 2);
        }
    }
}
