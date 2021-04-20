using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using IF4101_Lab1_Winform.DataAccess;

namespace IF4101_Lab1_Winform.Business
{
    class CurrencyBusiness
    {
        private ConnectionDataAccess connectionDataAccess;

        public CurrencyBusiness() // default constructor
        {
            this.CurrencyId = 0;
            this.CurrencyName = null;
            this.DollaValue = 0;
            this.connectionDataAccess = new ConnectionDataAccess();
        }
        public CurrencyBusiness(int currencyId, string currencyName, int dollarValue)
        {
            this.CurrencyId = currencyId;
            this.CurrencyName = currencyName;
            this.DollaValue = dollarValue;
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public int DollaValue { get; set; }

        public List<CurrencyBusiness> GetCurrencyData()
        {
            return this.connectionDataAccess.GetCurrencyData();
        }
    }
}
