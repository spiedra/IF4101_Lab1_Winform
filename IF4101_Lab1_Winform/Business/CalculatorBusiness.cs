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

        public decimal CalculateCurrencyExchange(string countryNameFrom, string countryNameTo, decimal amount)
        {
            decimal A = this.connectionDataAccess.GetDollarValueCurrency(countryNameFrom);
            decimal B = this.connectionDataAccess.GetDollarValueCurrency(countryNameTo);
            decimal DIVI = (A / B);
            decimal TOTAL =  amount / DIVI;
            return Math.Round(TOTAL, 2);
        }
    }
}
