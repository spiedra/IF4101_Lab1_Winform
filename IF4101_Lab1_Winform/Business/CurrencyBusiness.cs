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

        public CurrencyBusiness()
        {
            this.connectionDataAccess = new ConnectionDataAccess();
        }

        public List<CurrencyDataAccess> GetCurrencyData()
        {
            return this.connectionDataAccess.GetCurrencyData();
        }
    }
}
