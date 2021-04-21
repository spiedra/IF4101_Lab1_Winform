using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using IF4101_Lab1_Winform.DataAccess;

namespace IF4101_Lab1_Winform.Business
{
    class CurrencyBusiness
    {
        private CurrencyDataAccess currencyDataAcces;

        public CurrencyBusiness() // default constructor
        {
            this.CurrencyId = 0;
            this.CurrencyName = null;
            this.DollaValue = 0;
            this.currencyDataAcces = new CurrencyDataAccess();
        }
        public CurrencyBusiness(int currencyId, string currencyName, decimal dollarValue)
        {
            this.CurrencyId = currencyId;
            this.CurrencyName = currencyName;
            this.DollaValue = dollarValue;
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal DollaValue { get; set; }

        public List<CurrencyBusiness> GetCurrencyData()
        {
            return this.currencyDataAcces.GetCurrencyData();
        }
    }
}
